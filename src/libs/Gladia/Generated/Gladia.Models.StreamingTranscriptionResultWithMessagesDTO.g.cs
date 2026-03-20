
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingTranscriptionResultWithMessagesDTO
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
        /// If `named_entity_recognition` has been enabled, the detected entities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("named_entity_recognition")]
        public global::Gladia.NamedEntityRecognitionDTO? NamedEntityRecognition { get; set; }

        /// <summary>
        /// If `sentiment_analysis` has been enabled, sentiment analysis of the audio speech transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public global::Gladia.SentimentAnalysisDTO? SentimentAnalysis { get; set; }

        /// <summary>
        /// If `chapterization` has been enabled, will generate chapters name for different parts of the given audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapterization")]
        public global::Gladia.ChapterizationDTO? Chapterization { get; set; }

        /// <summary>
        /// Real-Time messages sent by the server during the live transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTranscriptionResultWithMessagesDTO" /> class.
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
        /// <param name="namedEntityRecognition">
        /// If `named_entity_recognition` has been enabled, the detected entities
        /// </param>
        /// <param name="sentimentAnalysis">
        /// If `sentiment_analysis` has been enabled, sentiment analysis of the audio speech transcription
        /// </param>
        /// <param name="chapterization">
        /// If `chapterization` has been enabled, will generate chapters name for different parts of the given audio.
        /// </param>
        /// <param name="messages">
        /// Real-Time messages sent by the server during the live transcription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingTranscriptionResultWithMessagesDTO(
            global::Gladia.TranscriptionMetadataDTO metadata,
            global::Gladia.TranscriptionDTO? transcription,
            global::Gladia.TranslationDTO? translation,
            global::Gladia.SummarizationDTO? summarization,
            global::Gladia.NamedEntityRecognitionDTO? namedEntityRecognition,
            global::Gladia.SentimentAnalysisDTO? sentimentAnalysis,
            global::Gladia.ChapterizationDTO? chapterization,
            global::System.Collections.Generic.IList<string>? messages)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Transcription = transcription;
            this.Translation = translation;
            this.Summarization = summarization;
            this.NamedEntityRecognition = namedEntityRecognition;
            this.SentimentAnalysis = sentimentAnalysis;
            this.Chapterization = chapterization;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTranscriptionResultWithMessagesDTO" /> class.
        /// </summary>
        public StreamingTranscriptionResultWithMessagesDTO()
        {
        }
    }
}