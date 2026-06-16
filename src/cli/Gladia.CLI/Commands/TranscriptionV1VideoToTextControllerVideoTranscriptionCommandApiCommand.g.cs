#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class TranscriptionV1VideoToTextControllerVideoTranscriptionCommandApiCommand
{
    private static Option<byte[]?> Video { get; } = new(
        name: @"--video")
    {
        Description = @"",
    };

    private static Option<string?> Videoname { get; } = new(
        name: @"--videoname")
    {
        Description = @"",
    };

    private static Option<string?> VideoUrl { get; } = new(
        name: @"--video-url")
    {
        Description = @"",
    };

    private static Option<global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour?> LanguageBehaviour { get; } = new(
        name: @"--language-behaviour")
    {
        Description = @"",
    };

    private static Option<global::Gladia.VideoToTextControllerVideoTranscriptionRequestLanguage?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"",
    };

    private static Option<string?> TranscriptionHint { get; } = new(
        name: @"--transcription-hint")
    {
        Description = @"",
    };

    private static Option<bool?> ToggleDiarization { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--toggle-diarization",
        description: @"");

    private static Option<int?> DiarizationNumSpeakers { get; } = new(
        name: @"--diarization-num-speakers")
    {
        Description = @"",
    };

    private static Option<int?> DiarizationMinSpeakers { get; } = new(
        name: @"--diarization-min-speakers")
    {
        Description = @"",
    };

    private static Option<int?> DiarizationMaxSpeakers { get; } = new(
        name: @"--diarization-max-speakers")
    {
        Description = @"",
    };

    private static Option<bool?> ToggleDirectTranslate { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--toggle-direct-translate",
        description: @"");

    private static Option<global::Gladia.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage?> TargetTranslationLanguage { get; } = new(
        name: @"--target-translation-language")
    {
        Description = @"",
    };

    private static Option<global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
    };

    private static Option<bool?> ToggleNoiseReduction { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--toggle-noise-reduction",
        description: @"");

    private static Option<bool?> ToggleAccurateWordsTimestamps { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--toggle-accurate-words-timestamps",
        description: @"");

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"video-to-text-controller-video-transcription", @"");
                        command.Options.Add(Video);
                        command.Options.Add(Videoname);
                        command.Options.Add(VideoUrl);
                        command.Options.Add(LanguageBehaviour);
                        command.Options.Add(Language);
                        command.Options.Add(TranscriptionHint);
                        command.Options.Add(ToggleDiarization);
                        command.Options.Add(DiarizationNumSpeakers);
                        command.Options.Add(DiarizationMinSpeakers);
                        command.Options.Add(DiarizationMaxSpeakers);
                        command.Options.Add(ToggleDirectTranslate);
                        command.Options.Add(TargetTranslationLanguage);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(ToggleNoiseReduction);
                        command.Options.Add(ToggleAccurateWordsTimestamps);
                        command.Options.Add(WebhookUrl);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Gladia.VideoToTextControllerVideoTranscriptionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Gladia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var video = CliRuntime.WasSpecified(parseResult, Video) ? parseResult.GetValue(Video) : (__requestBase is { } __VideoBaseValue ? __VideoBaseValue.Video : default);
                        var videoname = CliRuntime.WasSpecified(parseResult, Videoname) ? parseResult.GetValue(Videoname) : (__requestBase is { } __VideonameBaseValue ? __VideonameBaseValue.Videoname : default);
                        var videoUrl = CliRuntime.WasSpecified(parseResult, VideoUrl) ? parseResult.GetValue(VideoUrl) : (__requestBase is { } __VideoUrlBaseValue ? __VideoUrlBaseValue.VideoUrl : default);
                        var languageBehaviour = CliRuntime.WasSpecified(parseResult, LanguageBehaviour) ? parseResult.GetValue(LanguageBehaviour) : (__requestBase is { } __LanguageBehaviourBaseValue ? __LanguageBehaviourBaseValue.LanguageBehaviour : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var transcriptionHint = CliRuntime.WasSpecified(parseResult, TranscriptionHint) ? parseResult.GetValue(TranscriptionHint) : (__requestBase is { } __TranscriptionHintBaseValue ? __TranscriptionHintBaseValue.TranscriptionHint : default);
                        var toggleDiarization = CliRuntime.WasSpecified(parseResult, ToggleDiarization) ? parseResult.GetValue(ToggleDiarization) : (__requestBase is { } __ToggleDiarizationBaseValue ? __ToggleDiarizationBaseValue.ToggleDiarization : default);
                        var diarizationNumSpeakers = CliRuntime.WasSpecified(parseResult, DiarizationNumSpeakers) ? parseResult.GetValue(DiarizationNumSpeakers) : (__requestBase is { } __DiarizationNumSpeakersBaseValue ? __DiarizationNumSpeakersBaseValue.DiarizationNumSpeakers : default);
                        var diarizationMinSpeakers = CliRuntime.WasSpecified(parseResult, DiarizationMinSpeakers) ? parseResult.GetValue(DiarizationMinSpeakers) : (__requestBase is { } __DiarizationMinSpeakersBaseValue ? __DiarizationMinSpeakersBaseValue.DiarizationMinSpeakers : default);
                        var diarizationMaxSpeakers = CliRuntime.WasSpecified(parseResult, DiarizationMaxSpeakers) ? parseResult.GetValue(DiarizationMaxSpeakers) : (__requestBase is { } __DiarizationMaxSpeakersBaseValue ? __DiarizationMaxSpeakersBaseValue.DiarizationMaxSpeakers : default);
                        var toggleDirectTranslate = CliRuntime.WasSpecified(parseResult, ToggleDirectTranslate) ? parseResult.GetValue(ToggleDirectTranslate) : (__requestBase is { } __ToggleDirectTranslateBaseValue ? __ToggleDirectTranslateBaseValue.ToggleDirectTranslate : default);
                        var targetTranslationLanguage = CliRuntime.WasSpecified(parseResult, TargetTranslationLanguage) ? parseResult.GetValue(TargetTranslationLanguage) : (__requestBase is { } __TargetTranslationLanguageBaseValue ? __TargetTranslationLanguageBaseValue.TargetTranslationLanguage : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var toggleNoiseReduction = CliRuntime.WasSpecified(parseResult, ToggleNoiseReduction) ? parseResult.GetValue(ToggleNoiseReduction) : (__requestBase is { } __ToggleNoiseReductionBaseValue ? __ToggleNoiseReductionBaseValue.ToggleNoiseReduction : default);
                        var toggleAccurateWordsTimestamps = CliRuntime.WasSpecified(parseResult, ToggleAccurateWordsTimestamps) ? parseResult.GetValue(ToggleAccurateWordsTimestamps) : (__requestBase is { } __ToggleAccurateWordsTimestampsBaseValue ? __ToggleAccurateWordsTimestampsBaseValue.ToggleAccurateWordsTimestamps : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.TranscriptionV1.VideoToTextControllerVideoTranscriptionAsync(
                                    video: video,
                                    videoname: videoname,
                                    videoUrl: videoUrl,
                                    languageBehaviour: languageBehaviour,
                                    language: language,
                                    transcriptionHint: transcriptionHint,
                                    toggleDiarization: toggleDiarization,
                                    diarizationNumSpeakers: diarizationNumSpeakers,
                                    diarizationMinSpeakers: diarizationMinSpeakers,
                                    diarizationMaxSpeakers: diarizationMaxSpeakers,
                                    toggleDirectTranslate: toggleDirectTranslate,
                                    targetTranslationLanguage: targetTranslationLanguage,
                                    outputFormat: outputFormat,
                                    toggleNoiseReduction: toggleNoiseReduction,
                                    toggleAccurateWordsTimestamps: toggleAccurateWordsTimestamps,
                                    webhookUrl: webhookUrl,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}