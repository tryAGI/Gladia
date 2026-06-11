#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class LiveV2StreamingControllerInitStreamingSessionV2CommandApiCommand
{
    private static Option<global::Gladia.StreamingSupportedRegions?> Region { get; } = new(
        name: @"--region")
    {
        Description = @"The region used to process the audio.",
    };

    private static Option<global::Gladia.StreamingSupportedEncodingEnum?> Encoding { get; } = new(
        name: @"--encoding")
    {
        Description = @"The encoding format of the audio stream. Supported formats:
- PCM: 8, 16, 24, and 32 bits
- A-law: 8 bits
- μ-law: 8 bits

Note: No need to add WAV headers to raw audio as the API supports both formats.",
    };

    private static Option<double?> BitDepth { get; } = new(
        name: @"--bit-depth")
    {
        Description = @"The bit depth of the audio stream",
    };

    private static Option<double?> SampleRate { get; } = new(
        name: @"--sample-rate")
    {
        Description = @"The sample rate of the audio stream",
    };

    private static Option<int?> Channels { get; } = new(
        name: @"--channels")
    {
        Description = @"The number of channels of the audio stream",
    };

    private static Option<object?> CustomMetadata { get; } = new(
        name: @"--custom-metadata")
    {
        Description = @"Custom metadata you can attach to this live transcription",
    };

    private static Option<global::Gladia.StreamingSupportedModels?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model used to process the audio. ""solaria-1"" is used by default.",
    };

    private static Option<double?> Endpointing { get; } = new(
        name: @"--endpointing")
    {
        Description = @"The endpointing duration in seconds. Endpointing is the duration of silence which will cause an utterance to be considered as finished",
    };

    private static Option<double?> MaximumDurationWithoutEndpointing { get; } = new(
        name: @"--maximum-duration-without-endpointing")
    {
        Description = @"The maximum duration in seconds without endpointing. If endpointing is not detected after this duration, current utterance will be considered as finished",
    };

    private static Option<global::Gladia.PreProcessingConfig?> PreProcessing { get; } = new(
        name: @"--pre-processing")
    {
        Description = @"Specify the pre-processing configuration",
    };

    private static Option<global::Gladia.RealtimeProcessingConfig?> RealtimeProcessing { get; } = new(
        name: @"--realtime-processing")
    {
        Description = @"Specify the realtime processing configuration",
    };

    private static Option<global::Gladia.PostProcessingConfig?> PostProcessing { get; } = new(
        name: @"--post-processing")
    {
        Description = @"Specify the post-processing configuration",
    };

    private static Option<global::Gladia.MessagesConfig?> MessagesConfig { get; } = new(
        name: @"--messages-config")
    {
        Description = @"Specify the websocket messages configuration",
    };

    private static Option<bool?> Callback { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--callback",
        description: @"If true, messages will be sent to configured url.");

    private static Option<global::Gladia.CallbackConfig?> CallbackConfig { get; } = new(
        name: @"--callback-config")
    {
        Description = @"Specify the callback configuration",
    };
    private static readonly LanguageConfigOptionSet LanguageConfigOptions = LanguageConfigOptionSet.Create(@"language-config");
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

                    private static string FormatResponse(ParseResult parseResult, global::Gladia.InitStreamingResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Gladia.InitStreamingResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"streaming-controller-init-streaming-session-v2", @"Initiate a new live job");
                        command.Options.Add(Region);
                        command.Options.Add(Encoding);
                        command.Options.Add(BitDepth);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Channels);
                        command.Options.Add(CustomMetadata);
                        command.Options.Add(Model);
                        command.Options.Add(Endpointing);
                        command.Options.Add(MaximumDurationWithoutEndpointing);
                        command.Options.Add(PreProcessing);
                        command.Options.Add(RealtimeProcessing);
                        command.Options.Add(PostProcessing);
                        command.Options.Add(MessagesConfig);
                        command.Options.Add(Callback);
                        command.Options.Add(CallbackConfig);                        command.Options.Add(LanguageConfigOptions.Languages);
                        command.Options.Add(LanguageConfigOptions.CodeSwitching);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Gladia.StreamingRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Gladia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var region = parseResult.GetValue(Region);
                        var encoding = CliRuntime.WasSpecified(parseResult, Encoding) ? parseResult.GetValue(Encoding) : __requestBase is not null ? __requestBase.Encoding : default;
                        var bitDepth = CliRuntime.WasSpecified(parseResult, BitDepth) ? parseResult.GetValue(BitDepth) : __requestBase is not null ? __requestBase.BitDepth : default;
                        var sampleRate = CliRuntime.WasSpecified(parseResult, SampleRate) ? parseResult.GetValue(SampleRate) : __requestBase is not null ? __requestBase.SampleRate : default;
                        var channels = CliRuntime.WasSpecified(parseResult, Channels) ? parseResult.GetValue(Channels) : __requestBase is not null ? __requestBase.Channels : default;
                        var customMetadata = CliRuntime.WasSpecified(parseResult, CustomMetadata) ? parseResult.GetValue(CustomMetadata) : __requestBase is not null ? __requestBase.CustomMetadata : default;
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : __requestBase is not null ? __requestBase.Model : default;
                        var endpointing = CliRuntime.WasSpecified(parseResult, Endpointing) ? parseResult.GetValue(Endpointing) : __requestBase is not null ? __requestBase.Endpointing : default;
                        var maximumDurationWithoutEndpointing = CliRuntime.WasSpecified(parseResult, MaximumDurationWithoutEndpointing) ? parseResult.GetValue(MaximumDurationWithoutEndpointing) : __requestBase is not null ? __requestBase.MaximumDurationWithoutEndpointing : default;
                        var preProcessing = CliRuntime.WasSpecified(parseResult, PreProcessing) ? parseResult.GetValue(PreProcessing) : __requestBase is not null ? __requestBase.PreProcessing : default;
                        var realtimeProcessing = CliRuntime.WasSpecified(parseResult, RealtimeProcessing) ? parseResult.GetValue(RealtimeProcessing) : __requestBase is not null ? __requestBase.RealtimeProcessing : default;
                        var postProcessing = CliRuntime.WasSpecified(parseResult, PostProcessing) ? parseResult.GetValue(PostProcessing) : __requestBase is not null ? __requestBase.PostProcessing : default;
                        var messagesConfig = CliRuntime.WasSpecified(parseResult, MessagesConfig) ? parseResult.GetValue(MessagesConfig) : __requestBase is not null ? __requestBase.MessagesConfig : default;
                        var callback = CliRuntime.WasSpecified(parseResult, Callback) ? parseResult.GetValue(Callback) : __requestBase is not null ? __requestBase.Callback : default;
                        var callbackConfig = CliRuntime.WasSpecified(parseResult, CallbackConfig) ? parseResult.GetValue(CallbackConfig) : __requestBase is not null ? __requestBase.CallbackConfig : default;

                        var __languageConfigBase = __requestBase?.LanguageConfig;                        var languageConfigLanguages = CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.Languages) ? parseResult.GetValue(LanguageConfigOptions.Languages) : __languageConfigBase is not null ? __languageConfigBase.Languages : default;
                        var languageConfigCodeSwitching = CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.CodeSwitching) ? parseResult.GetValue(LanguageConfigOptions.CodeSwitching) : __languageConfigBase is not null ? __languageConfigBase.CodeSwitching : default;
                        var __languageConfigSpecified = CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.Languages) || CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.CodeSwitching);
                        var languageConfig =
                            __languageConfigSpecified || __languageConfigBase is not null
                                ? new global::Gladia.LanguageConfig
                                {
	                                Languages = languageConfigLanguages,
                                CodeSwitching = languageConfigCodeSwitching,

                                }
                                : __languageConfigBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LiveV2.StreamingControllerInitStreamingSessionV2Async(
                                    region: region,
                                    encoding: encoding,
                                    bitDepth: bitDepth,
                                    sampleRate: sampleRate,
                                    channels: channels,
                                    customMetadata: customMetadata,
                                    model: model,
                                    endpointing: endpointing,
                                    maximumDurationWithoutEndpointing: maximumDurationWithoutEndpointing,
                                    preProcessing: preProcessing,
                                    realtimeProcessing: realtimeProcessing,
                                    postProcessing: postProcessing,
                                    messagesConfig: messagesConfig,
                                    callback: callback,
                                    callbackConfig: callbackConfig,
                                    languageConfig: languageConfig,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Gladia.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}