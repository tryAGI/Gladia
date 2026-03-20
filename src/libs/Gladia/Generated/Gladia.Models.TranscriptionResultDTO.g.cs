
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionResultDTO
    {
        /// <summary>
        /// Metadata for the given transcription &amp; audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Gladia.TranscriptionMetadataDTO Metadata { get; set; }

        /// <summary>
        /// Transcription of the audio speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::Gladia.TranscriptionDTO? Transcription { get; set; }

        /// <summary>
        /// If `translation` has been enabled, translation of the audio speech transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public global::Gladia.TranslationDTO? Translation { get; set; }

        /// <summary>
        /// If `summarization` has been enabled, summarization of the audio speech transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public global::Gladia.SummarizationDTO? Summarization { get; set; }

        /// <summary>
        /// If `moderation` has been enabled, moderation of the audio speech transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public global::Gladia.ModerationDTO? Moderation { get; set; }

        /// <summary>
        /// If `named_entity_recognition` has been enabled, the detected entities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("named_entity_recognition")]
        public global::Gladia.NamedEntityRecognitionDTO? NamedEntityRecognition { get; set; }

        /// <summary>
        /// If `name_consistency` has been enabled, Gladia will improve consistency of the names accross the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_consistency")]
        public global::Gladia.NamesConsistencyDTO? NameConsistency { get; set; }

        /// <summary>
        /// If `speaker_reidentification` has been enabled, results of the AI speaker reidentification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_reidentification")]
        public global::Gladia.SpeakerReidentificationDTO? SpeakerReidentification { get; set; }

        /// <summary>
        /// If `structured_data_extraction` has been enabled, structured data extraction results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_data_extraction")]
        public global::Gladia.StructuredDataExtractionDTO? StructuredDataExtraction { get; set; }

        /// <summary>
        /// If `sentiment_analysis` has been enabled, sentiment analysis of the audio speech transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public global::Gladia.SentimentAnalysisDTO? SentimentAnalysis { get; set; }

        /// <summary>
        /// If `audio_to_llm` has been enabled, audio to llm results of the audio speech transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_to_llm")]
        public global::Gladia.AudioToLlmListDTO? AudioToLlm { get; set; }

        /// <summary>
        /// If `sentences` has been enabled, sentences of the audio speech transcription. Deprecated: content will move to the `transcription` object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public global::Gladia.SentencesDTO? Sentences { get; set; }

        /// <summary>
        /// If `display_mode` has been enabled, the output will be reordered, creating new utterances when speakers overlapped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_mode")]
        public global::Gladia.DisplayModeDTO? DisplayMode { get; set; }

        /// <summary>
        /// If `chapterization` has been enabled, will generate chapters name for different parts of the given audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapterization")]
        public global::Gladia.ChapterizationDTO? Chapterization { get; set; }

        /// <summary>
        /// If `diarization` has been requested and an error has occurred, the result will appear here
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization")]
        public global::Gladia.DiarizationDTO? Diarization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResultDTO" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Metadata for the given transcription &amp; audio file
        /// </param>
        /// <param name="transcription">
        /// Transcription of the audio speech
        /// </param>
        /// <param name="translation">
        /// If `translation` has been enabled, translation of the audio speech transcription
        /// </param>
        /// <param name="summarization">
        /// If `summarization` has been enabled, summarization of the audio speech transcription
        /// </param>
        /// <param name="moderation">
        /// If `moderation` has been enabled, moderation of the audio speech transcription
        /// </param>
        /// <param name="namedEntityRecognition">
        /// If `named_entity_recognition` has been enabled, the detected entities
        /// </param>
        /// <param name="nameConsistency">
        /// If `name_consistency` has been enabled, Gladia will improve consistency of the names accross the transcription
        /// </param>
        /// <param name="speakerReidentification">
        /// If `speaker_reidentification` has been enabled, results of the AI speaker reidentification.
        /// </param>
        /// <param name="structuredDataExtraction">
        /// If `structured_data_extraction` has been enabled, structured data extraction results
        /// </param>
        /// <param name="sentimentAnalysis">
        /// If `sentiment_analysis` has been enabled, sentiment analysis of the audio speech transcription
        /// </param>
        /// <param name="audioToLlm">
        /// If `audio_to_llm` has been enabled, audio to llm results of the audio speech transcription
        /// </param>
        /// <param name="displayMode">
        /// If `display_mode` has been enabled, the output will be reordered, creating new utterances when speakers overlapped
        /// </param>
        /// <param name="chapterization">
        /// If `chapterization` has been enabled, will generate chapters name for different parts of the given audio.
        /// </param>
        /// <param name="diarization">
        /// If `diarization` has been requested and an error has occurred, the result will appear here
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionResultDTO(
            global::Gladia.TranscriptionMetadataDTO metadata,
            global::Gladia.TranscriptionDTO? transcription,
            global::Gladia.TranslationDTO? translation,
            global::Gladia.SummarizationDTO? summarization,
            global::Gladia.ModerationDTO? moderation,
            global::Gladia.NamedEntityRecognitionDTO? namedEntityRecognition,
            global::Gladia.NamesConsistencyDTO? nameConsistency,
            global::Gladia.SpeakerReidentificationDTO? speakerReidentification,
            global::Gladia.StructuredDataExtractionDTO? structuredDataExtraction,
            global::Gladia.SentimentAnalysisDTO? sentimentAnalysis,
            global::Gladia.AudioToLlmListDTO? audioToLlm,
            global::Gladia.DisplayModeDTO? displayMode,
            global::Gladia.ChapterizationDTO? chapterization,
            global::Gladia.DiarizationDTO? diarization)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Transcription = transcription;
            this.Translation = translation;
            this.Summarization = summarization;
            this.Moderation = moderation;
            this.NamedEntityRecognition = namedEntityRecognition;
            this.NameConsistency = nameConsistency;
            this.SpeakerReidentification = speakerReidentification;
            this.StructuredDataExtraction = structuredDataExtraction;
            this.SentimentAnalysis = sentimentAnalysis;
            this.AudioToLlm = audioToLlm;
            this.DisplayMode = displayMode;
            this.Chapterization = chapterization;
            this.Diarization = diarization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionResultDTO" /> class.
        /// </summary>
        public TranscriptionResultDTO()
        {
        }
    }
}