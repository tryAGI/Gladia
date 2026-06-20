#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class TranscriptionV2TranscriptionControllerInitPreRecordedJobV2CommandApiCommand
{
    private static Option<global::Gladia.CustomSpellingConfigDTO?> CustomSpellingConfig { get; } = new(
        name: @"--custom-spelling-config")
    {
        Description = @"**[Alpha]** Custom spelling configuration, if `custom_spelling` is enabled",
    };

    private static Option<object?> CustomMetadata { get; } = new(
        name: @"--custom-metadata")
    {
        Description = @"Custom metadata you can attach to this transcription",
    };
    private static readonly InitTranscriptionRequestOptionSet InitTranscriptionRequestOptionSetOptions = InitTranscriptionRequestOptionSet.Create();

    private static readonly CustomVocabularyConfigDTOOptionSet CustomVocabularyConfigOptions = CustomVocabularyConfigDTOOptionSet.Create(@"custom-vocabulary-config");

    private static readonly CallbackConfigDtoOptionSet CallbackConfigOptions = CallbackConfigDtoOptionSet.Create(@"callback-config");

    private static readonly SubtitlesConfigDTOOptionSet SubtitlesConfigOptions = SubtitlesConfigDTOOptionSet.Create(@"subtitles-config");

    private static readonly DiarizationConfigDTOOptionSet DiarizationConfigOptions = DiarizationConfigDTOOptionSet.Create(@"diarization-config");

    private static readonly TranslationConfigDTOOptionSet TranslationConfigOptions = TranslationConfigDTOOptionSet.Create(@"translation-config");

    private static readonly SummarizationConfigDTOOptionSet SummarizationConfigOptions = SummarizationConfigDTOOptionSet.Create(@"summarization-config");

    private static readonly AudioToLlmListConfigDTOOptionSet AudioToLlmConfigOptions = AudioToLlmListConfigDTOOptionSet.Create(@"audio-to-llm-config");

    private static readonly PiiRedactionConfigDTOOptionSet PiiRedactionConfigOptions = PiiRedactionConfigDTOOptionSet.Create(@"pii-redaction-config");

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

                    private static string FormatResponse(ParseResult parseResult, global::Gladia.InitPreRecordedTranscriptionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Gladia.InitPreRecordedTranscriptionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"transcription-controller-init-pre-recorded-job-v2", @"Initiate a new transcription job");
                        command.Options.Add(CustomSpellingConfig);
                        command.Options.Add(CustomMetadata);                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.CustomVocabulary);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Callback);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Subtitles);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Diarization);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Translation);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Summarization);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.NamedEntityRecognition);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.CustomSpelling);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.SentimentAnalysis);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.AudioToLlm);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.PiiRedaction);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Sentences);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.PunctuationEnhanced);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.AudioUrl);
                        command.Options.Add(InitTranscriptionRequestOptionSetOptions.Model);                        command.Options.Add(CustomVocabularyConfigOptions.DefaultIntensity);                        command.Options.Add(CallbackConfigOptions.Url);
                        command.Options.Add(CallbackConfigOptions.Method);                        command.Options.Add(SubtitlesConfigOptions.Formats);
                        command.Options.Add(SubtitlesConfigOptions.MinimumDuration);
                        command.Options.Add(SubtitlesConfigOptions.MaximumDuration);
                        command.Options.Add(SubtitlesConfigOptions.MaximumCharactersPerRow);
                        command.Options.Add(SubtitlesConfigOptions.MaximumRowsPerCaption);
                        command.Options.Add(SubtitlesConfigOptions.Style);                        command.Options.Add(DiarizationConfigOptions.NumberOfSpeakers);
                        command.Options.Add(DiarizationConfigOptions.MinSpeakers);
                        command.Options.Add(DiarizationConfigOptions.MaxSpeakers);                        command.Options.Add(TranslationConfigOptions.TargetLanguages);
                        command.Options.Add(TranslationConfigOptions.Model);
                        command.Options.Add(TranslationConfigOptions.MatchOriginalUtterances);
                        command.Options.Add(TranslationConfigOptions.Lipsync);
                        command.Options.Add(TranslationConfigOptions.ContextAdaptation);
                        command.Options.Add(TranslationConfigOptions.Context);
                        command.Options.Add(TranslationConfigOptions.Informal);                        command.Options.Add(SummarizationConfigOptions.Type);                        command.Options.Add(AudioToLlmConfigOptions.Model);                        command.Options.Add(PiiRedactionConfigOptions.EntityTypes);
                        command.Options.Add(PiiRedactionConfigOptions.ProcessedTextType);                        command.Options.Add(LanguageConfigOptions.Languages);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Gladia.InitTranscriptionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Gladia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var customSpellingConfig = CliRuntime.WasSpecified(parseResult, CustomSpellingConfig) ? parseResult.GetValue(CustomSpellingConfig) : (__requestBase is { } __CustomSpellingConfigBaseValue ? __CustomSpellingConfigBaseValue.CustomSpellingConfig : default);
                        var customMetadata = CliRuntime.WasSpecified(parseResult, CustomMetadata) ? parseResult.GetValue(CustomMetadata) : (__requestBase is { } __CustomMetadataBaseValue ? __CustomMetadataBaseValue.CustomMetadata : default);                        var customVocabulary = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.CustomVocabulary) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.CustomVocabulary) : (__requestBase is { } __CustomVocabularyBaseValue ? __CustomVocabularyBaseValue.CustomVocabulary : default);
                        var callback = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Callback) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Callback) : (__requestBase is { } __CallbackBaseValue ? __CallbackBaseValue.Callback : default);
                        var subtitles = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Subtitles) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Subtitles) : (__requestBase is { } __SubtitlesBaseValue ? __SubtitlesBaseValue.Subtitles : default);
                        var diarization = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Diarization) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Diarization) : (__requestBase is { } __DiarizationBaseValue ? __DiarizationBaseValue.Diarization : default);
                        var translation = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Translation) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Translation) : (__requestBase is { } __TranslationBaseValue ? __TranslationBaseValue.Translation : default);
                        var summarization = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Summarization) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Summarization) : (__requestBase is { } __SummarizationBaseValue ? __SummarizationBaseValue.Summarization : default);
                        var namedEntityRecognition = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.NamedEntityRecognition) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.NamedEntityRecognition) : (__requestBase is { } __NamedEntityRecognitionBaseValue ? __NamedEntityRecognitionBaseValue.NamedEntityRecognition : default);
                        var customSpelling = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.CustomSpelling) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.CustomSpelling) : (__requestBase is { } __CustomSpellingBaseValue ? __CustomSpellingBaseValue.CustomSpelling : default);
                        var sentimentAnalysis = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.SentimentAnalysis) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.SentimentAnalysis) : (__requestBase is { } __SentimentAnalysisBaseValue ? __SentimentAnalysisBaseValue.SentimentAnalysis : default);
                        var audioToLlm = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.AudioToLlm) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.AudioToLlm) : (__requestBase is { } __AudioToLlmBaseValue ? __AudioToLlmBaseValue.AudioToLlm : default);
                        var piiRedaction = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.PiiRedaction) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.PiiRedaction) : (__requestBase is { } __PiiRedactionBaseValue ? __PiiRedactionBaseValue.PiiRedaction : default);
                        var sentences = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Sentences) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Sentences) : (__requestBase is { } __SentencesBaseValue ? __SentencesBaseValue.Sentences : default);
                        var punctuationEnhanced = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.PunctuationEnhanced) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.PunctuationEnhanced) : (__requestBase is { } __PunctuationEnhancedBaseValue ? __PunctuationEnhancedBaseValue.PunctuationEnhanced : default);
                        var audioUrl = parseResult.GetRequiredValue(InitTranscriptionRequestOptionSetOptions.AudioUrl);
                        var model = CliRuntime.WasSpecified(parseResult, InitTranscriptionRequestOptionSetOptions.Model) ? parseResult.GetValue(InitTranscriptionRequestOptionSetOptions.Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);

                        var __CustomVocabularyConfigBase = __requestBase is { } __CustomVocabularyConfigBaseValue ? __CustomVocabularyConfigBaseValue.CustomVocabularyConfig : default;                        var customVocabularyConfigDefaultIntensity = CliRuntime.WasSpecified(parseResult, CustomVocabularyConfigOptions.DefaultIntensity) ? parseResult.GetValue(CustomVocabularyConfigOptions.DefaultIntensity) : (__CustomVocabularyConfigBase is { } __CustomVocabularyConfigdefaultIntensityBaseValue ? __CustomVocabularyConfigdefaultIntensityBaseValue.DefaultIntensity : default);
                        var __CustomVocabularyConfigSpecified = CliRuntime.WasSpecified(parseResult, CustomVocabularyConfigOptions.DefaultIntensity);
                        var customVocabularyConfig =
                            __CustomVocabularyConfigSpecified || __CustomVocabularyConfigBase is not null
                                ? new global::Gladia.CustomVocabularyConfigDTO
                                {
	                                DefaultIntensity = customVocabularyConfigDefaultIntensity,
	                                Vocabulary = __CustomVocabularyConfigBase is not null ? __CustomVocabularyConfigBase.Vocabulary : throw new CliException(@"CustomVocabularyConfig.vocabulary is required when using custom-vocabulary-config options. Provide it with --request-json or --request-file."),
                                }
                                : __CustomVocabularyConfigBase;

                        var __CallbackConfigBase = __requestBase is { } __CallbackConfigBaseValue ? __CallbackConfigBaseValue.CallbackConfig : default;                        var callbackConfigUrl = parseResult.GetValue(CallbackConfigOptions.Url);
                        var callbackConfigMethod = CliRuntime.WasSpecified(parseResult, CallbackConfigOptions.Method) ? parseResult.GetValue(CallbackConfigOptions.Method) : (__CallbackConfigBase is { } __CallbackConfigmethodBaseValue ? __CallbackConfigmethodBaseValue.Method : default);
                        var __CallbackConfigSpecified = CliRuntime.WasSpecified(parseResult, CallbackConfigOptions.Url) || CliRuntime.WasSpecified(parseResult, CallbackConfigOptions.Method);
                        var callbackConfig =
                            __CallbackConfigSpecified || __CallbackConfigBase is not null
                                ? new global::Gladia.CallbackConfigDto
                                {
	                                Url = callbackConfigUrl!,
                                Method = callbackConfigMethod,

                                }
                                : __CallbackConfigBase;

                        var __SubtitlesConfigBase = __requestBase is { } __SubtitlesConfigBaseValue ? __SubtitlesConfigBaseValue.SubtitlesConfig : default;                        var subtitlesConfigFormats = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.Formats) ? parseResult.GetValue(SubtitlesConfigOptions.Formats) : (__SubtitlesConfigBase is { } __SubtitlesConfigformatsBaseValue ? __SubtitlesConfigformatsBaseValue.Formats : default);
                        var subtitlesConfigMinimumDuration = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MinimumDuration) ? parseResult.GetValue(SubtitlesConfigOptions.MinimumDuration) : (__SubtitlesConfigBase is { } __SubtitlesConfigminimumDurationBaseValue ? __SubtitlesConfigminimumDurationBaseValue.MinimumDuration : default);
                        var subtitlesConfigMaximumDuration = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MaximumDuration) ? parseResult.GetValue(SubtitlesConfigOptions.MaximumDuration) : (__SubtitlesConfigBase is { } __SubtitlesConfigmaximumDurationBaseValue ? __SubtitlesConfigmaximumDurationBaseValue.MaximumDuration : default);
                        var subtitlesConfigMaximumCharactersPerRow = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MaximumCharactersPerRow) ? parseResult.GetValue(SubtitlesConfigOptions.MaximumCharactersPerRow) : (__SubtitlesConfigBase is { } __SubtitlesConfigmaximumCharactersPerRowBaseValue ? __SubtitlesConfigmaximumCharactersPerRowBaseValue.MaximumCharactersPerRow : default);
                        var subtitlesConfigMaximumRowsPerCaption = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MaximumRowsPerCaption) ? parseResult.GetValue(SubtitlesConfigOptions.MaximumRowsPerCaption) : (__SubtitlesConfigBase is { } __SubtitlesConfigmaximumRowsPerCaptionBaseValue ? __SubtitlesConfigmaximumRowsPerCaptionBaseValue.MaximumRowsPerCaption : default);
                        var subtitlesConfigStyle = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.Style) ? parseResult.GetValue(SubtitlesConfigOptions.Style) : (__SubtitlesConfigBase is { } __SubtitlesConfigstyleBaseValue ? __SubtitlesConfigstyleBaseValue.Style : default);
                        var __SubtitlesConfigSpecified = CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.Formats) || CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MinimumDuration) || CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MaximumDuration) || CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MaximumCharactersPerRow) || CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.MaximumRowsPerCaption) || CliRuntime.WasSpecified(parseResult, SubtitlesConfigOptions.Style);
                        var subtitlesConfig =
                            __SubtitlesConfigSpecified || __SubtitlesConfigBase is not null
                                ? new global::Gladia.SubtitlesConfigDTO
                                {
	                                Formats = subtitlesConfigFormats,
                                MinimumDuration = subtitlesConfigMinimumDuration,
                                MaximumDuration = subtitlesConfigMaximumDuration,
                                MaximumCharactersPerRow = subtitlesConfigMaximumCharactersPerRow,
                                MaximumRowsPerCaption = subtitlesConfigMaximumRowsPerCaption,
                                Style = subtitlesConfigStyle,

                                }
                                : __SubtitlesConfigBase;

                        var __DiarizationConfigBase = __requestBase is { } __DiarizationConfigBaseValue ? __DiarizationConfigBaseValue.DiarizationConfig : default;                        var diarizationConfigNumberOfSpeakers = CliRuntime.WasSpecified(parseResult, DiarizationConfigOptions.NumberOfSpeakers) ? parseResult.GetValue(DiarizationConfigOptions.NumberOfSpeakers) : (__DiarizationConfigBase is { } __DiarizationConfignumberOfSpeakersBaseValue ? __DiarizationConfignumberOfSpeakersBaseValue.NumberOfSpeakers : default);
                        var diarizationConfigMinSpeakers = CliRuntime.WasSpecified(parseResult, DiarizationConfigOptions.MinSpeakers) ? parseResult.GetValue(DiarizationConfigOptions.MinSpeakers) : (__DiarizationConfigBase is { } __DiarizationConfigminSpeakersBaseValue ? __DiarizationConfigminSpeakersBaseValue.MinSpeakers : default);
                        var diarizationConfigMaxSpeakers = CliRuntime.WasSpecified(parseResult, DiarizationConfigOptions.MaxSpeakers) ? parseResult.GetValue(DiarizationConfigOptions.MaxSpeakers) : (__DiarizationConfigBase is { } __DiarizationConfigmaxSpeakersBaseValue ? __DiarizationConfigmaxSpeakersBaseValue.MaxSpeakers : default);
                        var __DiarizationConfigSpecified = CliRuntime.WasSpecified(parseResult, DiarizationConfigOptions.NumberOfSpeakers) || CliRuntime.WasSpecified(parseResult, DiarizationConfigOptions.MinSpeakers) || CliRuntime.WasSpecified(parseResult, DiarizationConfigOptions.MaxSpeakers);
                        var diarizationConfig =
                            __DiarizationConfigSpecified || __DiarizationConfigBase is not null
                                ? new global::Gladia.DiarizationConfigDTO
                                {
	                                NumberOfSpeakers = diarizationConfigNumberOfSpeakers,
                                MinSpeakers = diarizationConfigMinSpeakers,
                                MaxSpeakers = diarizationConfigMaxSpeakers,

                                }
                                : __DiarizationConfigBase;

                        var __TranslationConfigBase = __requestBase is { } __TranslationConfigBaseValue ? __TranslationConfigBaseValue.TranslationConfig : default;                        var translationConfigTargetLanguages = parseResult.GetValue(TranslationConfigOptions.TargetLanguages);
                        var translationConfigModel = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Model) ? parseResult.GetValue(TranslationConfigOptions.Model) : (__TranslationConfigBase is { } __TranslationConfigmodelBaseValue ? __TranslationConfigmodelBaseValue.Model : default);
                        var translationConfigMatchOriginalUtterances = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.MatchOriginalUtterances) ? parseResult.GetValue(TranslationConfigOptions.MatchOriginalUtterances) : (__TranslationConfigBase is { } __TranslationConfigmatchOriginalUtterancesBaseValue ? __TranslationConfigmatchOriginalUtterancesBaseValue.MatchOriginalUtterances : default);
                        var translationConfigLipsync = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Lipsync) ? parseResult.GetValue(TranslationConfigOptions.Lipsync) : (__TranslationConfigBase is { } __TranslationConfiglipsyncBaseValue ? __TranslationConfiglipsyncBaseValue.Lipsync : default);
                        var translationConfigContextAdaptation = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.ContextAdaptation) ? parseResult.GetValue(TranslationConfigOptions.ContextAdaptation) : (__TranslationConfigBase is { } __TranslationConfigcontextAdaptationBaseValue ? __TranslationConfigcontextAdaptationBaseValue.ContextAdaptation : default);
                        var translationConfigContext = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Context) ? parseResult.GetValue(TranslationConfigOptions.Context) : (__TranslationConfigBase is { } __TranslationConfigcontextBaseValue ? __TranslationConfigcontextBaseValue.Context : default);
                        var translationConfigInformal = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Informal) ? parseResult.GetValue(TranslationConfigOptions.Informal) : (__TranslationConfigBase is { } __TranslationConfiginformalBaseValue ? __TranslationConfiginformalBaseValue.Informal : default);
                        var __TranslationConfigSpecified = CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.TargetLanguages) || CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Model) || CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.MatchOriginalUtterances) || CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Lipsync) || CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.ContextAdaptation) || CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Context) || CliRuntime.WasSpecified(parseResult, TranslationConfigOptions.Informal);
                        var translationConfig =
                            __TranslationConfigSpecified || __TranslationConfigBase is not null
                                ? new global::Gladia.TranslationConfigDTO
                                {
	                                TargetLanguages = translationConfigTargetLanguages!,
                                Model = translationConfigModel,
                                MatchOriginalUtterances = translationConfigMatchOriginalUtterances,
                                Lipsync = translationConfigLipsync,
                                ContextAdaptation = translationConfigContextAdaptation,
                                Context = translationConfigContext,
                                Informal = translationConfigInformal,

                                }
                                : __TranslationConfigBase;

                        var __SummarizationConfigBase = __requestBase is { } __SummarizationConfigBaseValue ? __SummarizationConfigBaseValue.SummarizationConfig : default;                        var summarizationConfigType = CliRuntime.WasSpecified(parseResult, SummarizationConfigOptions.Type) ? parseResult.GetValue(SummarizationConfigOptions.Type) : (__SummarizationConfigBase is { } __SummarizationConfigtypeBaseValue ? __SummarizationConfigtypeBaseValue.Type : default);
                        var __SummarizationConfigSpecified = CliRuntime.WasSpecified(parseResult, SummarizationConfigOptions.Type);
                        var summarizationConfig =
                            __SummarizationConfigSpecified || __SummarizationConfigBase is not null
                                ? new global::Gladia.SummarizationConfigDTO
                                {
	                                Type = summarizationConfigType,

                                }
                                : __SummarizationConfigBase;

                        var __AudioToLlmConfigBase = __requestBase is { } __AudioToLlmConfigBaseValue ? __AudioToLlmConfigBaseValue.AudioToLlmConfig : default;                        var audioToLlmConfigModel = CliRuntime.WasSpecified(parseResult, AudioToLlmConfigOptions.Model) ? parseResult.GetValue(AudioToLlmConfigOptions.Model) : (__AudioToLlmConfigBase is { } __AudioToLlmConfigmodelBaseValue ? __AudioToLlmConfigmodelBaseValue.Model : default);
                        var __AudioToLlmConfigSpecified = CliRuntime.WasSpecified(parseResult, AudioToLlmConfigOptions.Model);
                        var audioToLlmConfig =
                            __AudioToLlmConfigSpecified || __AudioToLlmConfigBase is not null
                                ? new global::Gladia.AudioToLlmListConfigDTO
                                {
	                                Model = audioToLlmConfigModel,
	                                Prompts = __AudioToLlmConfigBase is not null ? __AudioToLlmConfigBase.Prompts : throw new CliException(@"AudioToLlmConfig.prompts is required when using audio-to-llm-config options. Provide it with --request-json or --request-file."),
                                }
                                : __AudioToLlmConfigBase;

                        var __PiiRedactionConfigBase = __requestBase is { } __PiiRedactionConfigBaseValue ? __PiiRedactionConfigBaseValue.PiiRedactionConfig : default;                        var piiRedactionConfigEntityTypes = CliRuntime.WasSpecified(parseResult, PiiRedactionConfigOptions.EntityTypes) ? parseResult.GetValue(PiiRedactionConfigOptions.EntityTypes) : (__PiiRedactionConfigBase is { } __PiiRedactionConfigentityTypesBaseValue ? __PiiRedactionConfigentityTypesBaseValue.EntityTypes : default);
                        var piiRedactionConfigProcessedTextType = CliRuntime.WasSpecified(parseResult, PiiRedactionConfigOptions.ProcessedTextType) ? parseResult.GetValue(PiiRedactionConfigOptions.ProcessedTextType) : (__PiiRedactionConfigBase is { } __PiiRedactionConfigprocessedTextTypeBaseValue ? __PiiRedactionConfigprocessedTextTypeBaseValue.ProcessedTextType : default);
                        var __PiiRedactionConfigSpecified = CliRuntime.WasSpecified(parseResult, PiiRedactionConfigOptions.EntityTypes) || CliRuntime.WasSpecified(parseResult, PiiRedactionConfigOptions.ProcessedTextType);
                        var piiRedactionConfig =
                            __PiiRedactionConfigSpecified || __PiiRedactionConfigBase is not null
                                ? new global::Gladia.PiiRedactionConfigDTO
                                {
	                                EntityTypes = piiRedactionConfigEntityTypes,
                                ProcessedTextType = piiRedactionConfigProcessedTextType,

                                }
                                : __PiiRedactionConfigBase;

                        var __LanguageConfigBase = __requestBase is { } __LanguageConfigBaseValue ? __LanguageConfigBaseValue.LanguageConfig : default;                        var languageConfigLanguages = CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.Languages) ? parseResult.GetValue(LanguageConfigOptions.Languages) : (__LanguageConfigBase is { } __LanguageConfiglanguagesBaseValue ? __LanguageConfiglanguagesBaseValue.Languages : default);
                        var languageConfigCodeSwitching = CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.CodeSwitching) ? parseResult.GetValue(LanguageConfigOptions.CodeSwitching) : (__LanguageConfigBase is { } __LanguageConfigcodeSwitchingBaseValue ? __LanguageConfigcodeSwitchingBaseValue.CodeSwitching : default);
                        var __LanguageConfigSpecified = CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.Languages) || CliRuntime.WasSpecified(parseResult, LanguageConfigOptions.CodeSwitching);
                        var languageConfig =
                            __LanguageConfigSpecified || __LanguageConfigBase is not null
                                ? new global::Gladia.LanguageConfig
                                {
	                                Languages = languageConfigLanguages,
                                CodeSwitching = languageConfigCodeSwitching,

                                }
                                : __LanguageConfigBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TranscriptionV2.TranscriptionControllerInitPreRecordedJobV2Async(
                                    customSpellingConfig: customSpellingConfig,
                                    customMetadata: customMetadata,
                                    customVocabulary: customVocabulary,
                                    callback: callback,
                                    subtitles: subtitles,
                                    diarization: diarization,
                                    translation: translation,
                                    summarization: summarization,
                                    namedEntityRecognition: namedEntityRecognition,
                                    customSpelling: customSpelling,
                                    sentimentAnalysis: sentimentAnalysis,
                                    audioToLlm: audioToLlm,
                                    piiRedaction: piiRedaction,
                                    sentences: sentences,
                                    punctuationEnhanced: punctuationEnhanced,
                                    audioUrl: audioUrl,
                                    model: model,
                                    customVocabularyConfig: customVocabularyConfig,
                                    callbackConfig: callbackConfig,
                                    subtitlesConfig: subtitlesConfig,
                                    diarizationConfig: diarizationConfig,
                                    translationConfig: translationConfig,
                                    summarizationConfig: summarizationConfig,
                                    audioToLlmConfig: audioToLlmConfig,
                                    piiRedactionConfig: piiRedactionConfig,
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