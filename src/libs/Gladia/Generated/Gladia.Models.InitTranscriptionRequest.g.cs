
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitTranscriptionRequest
    {
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
        /// **[Alpha]** Enable named entity recognition for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("named_entity_recognition")]
        public bool? NamedEntityRecognition { get; set; }

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
        /// Custom metadata you can attach to this transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Enable sentences for this audio<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public bool? Sentences { get; set; }

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
        /// URL to a Gladia file or to an external audio or video file<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </summary>
        /// <example>http://files.gladia.io/example/audio-transcription/split_infinity.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTranscriptionRequest" /> class.
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
        /// <param name="namedEntityRecognition">
        /// **[Alpha]** Enable named entity recognition for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpelling">
        /// **[Alpha]** Enable custom spelling for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpellingConfig">
        /// **[Alpha]** Custom spelling configuration, if `custom_spelling` is enabled
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
        /// <param name="customMetadata">
        /// Custom metadata you can attach to this transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="sentences">
        /// Enable sentences for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="punctuationEnhanced">
        /// **[Alpha]** Use enhanced punctuation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="audioUrl">
        /// URL to a Gladia file or to an external audio or video file<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitTranscriptionRequest(
            string audioUrl,
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
            bool? namedEntityRecognition,
            bool? customSpelling,
            global::Gladia.CustomSpellingConfigDTO? customSpellingConfig,
            bool? sentimentAnalysis,
            bool? audioToLlm,
            global::Gladia.AudioToLlmListConfigDTO? audioToLlmConfig,
            bool? piiRedaction,
            global::Gladia.PiiRedactionConfigDTO? piiRedactionConfig,
            object? customMetadata,
            bool? sentences,
            bool? punctuationEnhanced,
            global::Gladia.LanguageConfig? languageConfig)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
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
            this.NamedEntityRecognition = namedEntityRecognition;
            this.CustomSpelling = customSpelling;
            this.CustomSpellingConfig = customSpellingConfig;
            this.SentimentAnalysis = sentimentAnalysis;
            this.AudioToLlm = audioToLlm;
            this.AudioToLlmConfig = audioToLlmConfig;
            this.PiiRedaction = piiRedaction;
            this.PiiRedactionConfig = piiRedactionConfig;
            this.CustomMetadata = customMetadata;
            this.Sentences = sentences;
            this.PunctuationEnhanced = punctuationEnhanced;
            this.LanguageConfig = languageConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTranscriptionRequest" /> class.
        /// </summary>
        public InitTranscriptionRequest()
        {
        }
    }
}