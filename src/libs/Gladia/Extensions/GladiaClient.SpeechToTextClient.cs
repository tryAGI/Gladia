#nullable enable

using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

namespace Gladia;

public sealed partial class GladiaClient : ISpeechToTextClient
{
    private SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_speechMetadata ??= new("gladia", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        var request = options?.RawRepresentationFactory?.Invoke(this) as InitTranscriptionRequest;

        // If no pre-built request or no audio URL provided, upload the stream first
        if (request is null || string.IsNullOrEmpty(request.AudioUrl))
        {
            MemoryStream? ms = audioSpeechStream as MemoryStream;
            if (ms is null || ms.Position != 0)
            {
                ms = new MemoryStream();
                await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
            }

            byte[] bytes = ms.TryGetBuffer(out ArraySegment<byte> buffer)
                && buffer.Array is not null && buffer.Offset == 0 && buffer.Count == ms.Length
                    ? buffer.Array
                    : ms.ToArray();

            var upload = await FileManagement.FileControllerUploadV2Async(
                audio: bytes,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            if (request is null)
            {
                request = new InitTranscriptionRequest
                {
                    AudioUrl = upload.AudioUrl,
                };
            }
            else
            {
                request.AudioUrl = upload.AudioUrl;
            }
        }

        // Map MEAI options to request
        if (options?.SpeechLanguage is { Length: > 0 } language
            && TranscriptionLanguageCodeEnumExtensions.ToEnum(language) is { } languageCode)
        {
            request.LanguageConfig ??= new LanguageConfig
            {
                Languages = [languageCode],
            };
        }

        // Initiate transcription job
        var job = await PreRecordedV2.PreRecordedControllerInitPreRecordedJobV2Async(
            request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        string id = job.Id.ToString();

        // Poll until done
        PreRecordedResponse response;
        do
        {
            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
            response = await PreRecordedV2.PreRecordedControllerGetPreRecordedJobV2Async(
                id,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        while (response.Status is PreRecordedResponseStatus.Queued or PreRecordedResponseStatus.Processing);

        if (response.Status is PreRecordedResponseStatus.Error)
        {
            throw new InvalidOperationException(
                $"Gladia transcription job {id} failed with error code {response.ErrorCode}.");
        }

        string text = response.Result?.Transcription?.FullTranscript ?? string.Empty;

        TimeSpan? startTime = null;
        TimeSpan? endTime = null;
        if (response.Result?.Transcription?.Utterances is { Count: > 0 } utterances)
        {
            startTime = TimeSpan.FromSeconds(utterances[0].Start);
            endTime = TimeSpan.FromSeconds(utterances[^1].End);
        }

        return new SpeechToTextResponse(text)
        {
            RawRepresentation = response,
            ResponseId = id,
            StartTime = startTime,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((ISpeechToTextClient)this)
            .GetTextAsync(audioSpeechStream, options, cancellationToken)
            .ConfigureAwait(false);

        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }
}
