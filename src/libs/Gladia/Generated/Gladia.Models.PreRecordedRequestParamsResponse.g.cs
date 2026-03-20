
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreRecordedRequestParamsResponse
    {
        /// <summary>
        /// **[Deprecated]** Context to feed the transcription model with for possible better accuracy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ContextPrompt { get; set; }

        /// <summary>
        /// **[Beta]** Can be either boolean to enable custom_vocabulary for this audio or an array with specific vocabulary list to feed the transcription model with<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabulary")]
        public bool? CustomVocabulary { get; set; }

        /// <summary>
        /// **[Beta]** Custom vocabulary configuration, if `custom_vocabulary` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabulary_config")]
        public global::Gladia.CustomVocabularyConfigDTO? CustomVocabularyConfig { get; set; }

        /// <summary>
        /// **[Deprecated]** Use `language_config` instead. Detect the language from the given audio<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_language")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DetectLanguage { get; set; }

        /// <summary>
        /// **[Deprecated]** Use `language_config` instead.Detect multiple languages in the given audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_code_switching")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnableCodeSwitching { get; set; }

        /// <summary>
        /// **[Deprecated]** Use `language_config` instead. Specify the configuration for code switching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_switching_config")]
        public global::Gladia.CodeSwitchingConfigDTO? CodeSwitchingConfig { get; set; }

        /// <summary>
        /// **[Deprecated]** Use `language_config` instead. Set the spoken language for the given audio (ISO 639 standard)<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter))]
        public global::Gladia.TranscriptionLanguageCodeEnum? Language { get; set; }

        /// <summary>
        /// **[Deprecated]** Use `callback`/`callback_config` instead. Callback URL we will do a `POST` request to with the result of the transcription<br/>
        /// Example: http://callback.example
        /// </summary>
        /// <example>http://callback.example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Enable callback for this transcription. If true, the `callback_config` property will be used to customize the callback behaviour<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public bool? Callback { get; set; }

        /// <summary>
        /// Customize the callback behaviour (url and http method)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_config")]
        public global::Gladia.CallbackConfigDto? CallbackConfig { get; set; }

        /// <summary>
        /// Enable subtitles generation for this transcription<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        public bool? Subtitles { get; set; }

        /// <summary>
        /// Configuration for subtitles generation if `subtitles` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles_config")]
        public global::Gladia.SubtitlesConfigDTO? SubtitlesConfig { get; set; }

        /// <summary>
        /// Enable speaker recognition (diarization) for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization")]
        public bool? Diarization { get; set; }

        /// <summary>
        /// Speaker recognition configuration, if `diarization` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_config")]
        public global::Gladia.DiarizationConfigDTO? DiarizationConfig { get; set; }

        /// <summary>
        /// **[Beta]** Enable translation for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public bool? Translation { get; set; }

        /// <summary>
        /// **[Beta]** Translation configuration, if `translation` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_config")]
        public global::Gladia.TranslationConfigDTO? TranslationConfig { get; set; }

        /// <summary>
        /// **[Beta]** Enable summarization for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// **[Beta]** Summarization configuration, if `summarization` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization_config")]
        public global::Gladia.SummarizationConfigDTO? SummarizationConfig { get; set; }

        /// <summary>
        /// **[Alpha]** Enable moderation for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        /// **[Alpha]** Enable named entity recognition for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("named_entity_recognition")]
        public bool? NamedEntityRecognition { get; set; }

        /// <summary>
        /// **[Alpha]** Enable chapterization for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapterization")]
        public bool? Chapterization { get; set; }

        /// <summary>
        /// **[Alpha]** Enable names consistency for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_consistency")]
        public bool? NameConsistency { get; set; }

        /// <summary>
        /// **[Alpha]** Enable custom spelling for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public bool? CustomSpelling { get; set; }

        /// <summary>
        /// **[Alpha]** Custom spelling configuration, if `custom_spelling` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling_config")]
        public global::Gladia.CustomSpellingConfigDTO? CustomSpellingConfig { get; set; }

        /// <summary>
        /// **[Alpha]** Enable structured data extraction for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_data_extraction")]
        public bool? StructuredDataExtraction { get; set; }

        /// <summary>
        /// **[Alpha]** Structured data extraction configuration, if `structured_data_extraction` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_data_extraction_config")]
        public global::Gladia.StructuredDataExtractionConfigDTO? StructuredDataExtractionConfig { get; set; }

        /// <summary>
        /// Enable sentiment analysis for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// **[Alpha]** Enable audio to llm processing for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_to_llm")]
        public bool? AudioToLlm { get; set; }

        /// <summary>
        /// **[Alpha]** Audio to llm configuration, if `audio_to_llm` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_to_llm_config")]
        public global::Gladia.AudioToLlmListConfigDTO? AudioToLlmConfig { get; set; }

        /// <summary>
        /// Enable PII redaction for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_redaction")]
        public bool? PiiRedaction { get; set; }

        /// <summary>
        /// PII redaction configuration, if `pii_redaction` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_redaction_config")]
        public global::Gladia.PiiRedactionConfigDTO? PiiRedactionConfig { get; set; }

        /// <summary>
        /// Enable sentences for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public bool? Sentences { get; set; }

        /// <summary>
        /// **[Alpha]** Allows to change the output display_mode for this audio. The output will be reordered, creating new utterances when speakers overlapped<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_mode")]
        public bool? DisplayMode { get; set; }

        /// <summary>
        /// **[Alpha]** Use enhanced punctuation for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuation_enhanced")]
        public bool? PunctuationEnhanced { get; set; }

        /// <summary>
        /// Specify the language configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_config")]
        public global::Gladia.LanguageConfig? LanguageConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreRecordedRequestParamsResponse" /> class.
        /// </summary>
        /// <param name="customVocabulary">
        /// **[Beta]** Can be either boolean to enable custom_vocabulary for this audio or an array with specific vocabulary list to feed the transcription model with<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customVocabularyConfig">
        /// **[Beta]** Custom vocabulary configuration, if `custom_vocabulary` is enabled
        /// </param>
        /// <param name="callback">
        /// Enable callback for this transcription. If true, the `callback_config` property will be used to customize the callback behaviour<br/>
        /// Default Value: false
        /// </param>
        /// <param name="callbackConfig">
        /// Customize the callback behaviour (url and http method)
        /// </param>
        /// <param name="subtitles">
        /// Enable subtitles generation for this transcription<br/>
        /// Default Value: false
        /// </param>
        /// <param name="subtitlesConfig">
        /// Configuration for subtitles generation if `subtitles` is enabled
        /// </param>
        /// <param name="diarization">
        /// Enable speaker recognition (diarization) for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="diarizationConfig">
        /// Speaker recognition configuration, if `diarization` is enabled
        /// </param>
        /// <param name="translation">
        /// **[Beta]** Enable translation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="translationConfig">
        /// **[Beta]** Translation configuration, if `translation` is enabled
        /// </param>
        /// <param name="summarization">
        /// **[Beta]** Enable summarization for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summarizationConfig">
        /// **[Beta]** Summarization configuration, if `summarization` is enabled
        /// </param>
        /// <param name="moderation">
        /// **[Alpha]** Enable moderation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="namedEntityRecognition">
        /// **[Alpha]** Enable named entity recognition for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chapterization">
        /// **[Alpha]** Enable chapterization for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nameConsistency">
        /// **[Alpha]** Enable names consistency for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpelling">
        /// **[Alpha]** Enable custom spelling for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpellingConfig">
        /// **[Alpha]** Custom spelling configuration, if `custom_spelling` is enabled
        /// </param>
        /// <param name="structuredDataExtraction">
        /// **[Alpha]** Enable structured data extraction for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="structuredDataExtractionConfig">
        /// **[Alpha]** Structured data extraction configuration, if `structured_data_extraction` is enabled
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable sentiment analysis for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioToLlm">
        /// **[Alpha]** Enable audio to llm processing for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioToLlmConfig">
        /// **[Alpha]** Audio to llm configuration, if `audio_to_llm` is enabled
        /// </param>
        /// <param name="piiRedaction">
        /// Enable PII redaction for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="piiRedactionConfig">
        /// PII redaction configuration, if `pii_redaction` is enabled
        /// </param>
        /// <param name="sentences">
        /// Enable sentences for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="displayMode">
        /// **[Alpha]** Allows to change the output display_mode for this audio. The output will be reordered, creating new utterances when speakers overlapped<br/>
        /// Default Value: false
        /// </param>
        /// <param name="punctuationEnhanced">
        /// **[Alpha]** Use enhanced punctuation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="audioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreRecordedRequestParamsResponse(
            bool? customVocabulary,
            global::Gladia.CustomVocabularyConfigDTO? customVocabularyConfig,
            bool? callback,
            global::Gladia.CallbackConfigDto? callbackConfig,
            bool? subtitles,
            global::Gladia.SubtitlesConfigDTO? subtitlesConfig,
            bool? diarization,
            global::Gladia.DiarizationConfigDTO? diarizationConfig,
            bool? translation,
            global::Gladia.TranslationConfigDTO? translationConfig,
            bool? summarization,
            global::Gladia.SummarizationConfigDTO? summarizationConfig,
            bool? moderation,
            bool? namedEntityRecognition,
            bool? chapterization,
            bool? nameConsistency,
            bool? customSpelling,
            global::Gladia.CustomSpellingConfigDTO? customSpellingConfig,
            bool? structuredDataExtraction,
            global::Gladia.StructuredDataExtractionConfigDTO? structuredDataExtractionConfig,
            bool? sentimentAnalysis,
            bool? audioToLlm,
            global::Gladia.AudioToLlmListConfigDTO? audioToLlmConfig,
            bool? piiRedaction,
            global::Gladia.PiiRedactionConfigDTO? piiRedactionConfig,
            bool? sentences,
            bool? displayMode,
            bool? punctuationEnhanced,
            global::Gladia.LanguageConfig? languageConfig,
            string? audioUrl)
        {
            this.CustomVocabulary = customVocabulary;
            this.CustomVocabularyConfig = customVocabularyConfig;
            this.Callback = callback;
            this.CallbackConfig = callbackConfig;
            this.Subtitles = subtitles;
            this.SubtitlesConfig = subtitlesConfig;
            this.Diarization = diarization;
            this.DiarizationConfig = diarizationConfig;
            this.Translation = translation;
            this.TranslationConfig = translationConfig;
            this.Summarization = summarization;
            this.SummarizationConfig = summarizationConfig;
            this.Moderation = moderation;
            this.NamedEntityRecognition = namedEntityRecognition;
            this.Chapterization = chapterization;
            this.NameConsistency = nameConsistency;
            this.CustomSpelling = customSpelling;
            this.CustomSpellingConfig = customSpellingConfig;
            this.StructuredDataExtraction = structuredDataExtraction;
            this.StructuredDataExtractionConfig = structuredDataExtractionConfig;
            this.SentimentAnalysis = sentimentAnalysis;
            this.AudioToLlm = audioToLlm;
            this.AudioToLlmConfig = audioToLlmConfig;
            this.PiiRedaction = piiRedaction;
            this.PiiRedactionConfig = piiRedactionConfig;
            this.Sentences = sentences;
            this.DisplayMode = displayMode;
            this.PunctuationEnhanced = punctuationEnhanced;
            this.LanguageConfig = languageConfig;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreRecordedRequestParamsResponse" /> class.
        /// </summary>
        public PreRecordedRequestParamsResponse()
        {
        }
    }
}