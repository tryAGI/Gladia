#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class TranscriptionV2TranscriptionControllerGetAudioV2CommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Id of the transcription job",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"transcription-controller-get-audio-v2", @"Download the audio file used for this transcription job");
                        command.Arguments.Add(Id);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TranscriptionV2.TranscriptionControllerGetAudioV2Async(
                                    id: id,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}