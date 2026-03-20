
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationResultDTO
    {
        /// <summary>
        /// Contains the error details of the failed addon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Gladia.AddonErrorDTO? Error { get; set; }

        /// <summary>
        /// All transcription on text format without any other information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullTranscript { get; set; }

        /// <summary>
        /// All the detected languages in the audio sorted from the most detected to the less detected<br/>
        /// Example: [en]
        /// </summary>
        /// <example>[en]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum> Languages { get; set; }

        /// <summary>
        /// If `sentences` has been enabled, sentences results for this translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public global::System.Collections.Generic.IList<global::Gladia.SentencesDTO>? Sentences { get; set; }

        /// <summary>
        /// If `subtitles` has been enabled, subtitles results for this translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        public global::System.Collections.Generic.IList<global::Gladia.SubtitleDTO>? Subtitles { get; set; }

        /// <summary>
        /// Transcribed speech utterances present in the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Gladia.UtteranceDTO> Utterances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResultDTO" /> class.
        /// </summary>
        /// <param name="error">
        /// Contains the error details of the failed addon
        /// </param>
        /// <param name="fullTranscript">
        /// All transcription on text format without any other information
        /// </param>
        /// <param name="languages">
        /// All the detected languages in the audio sorted from the most detected to the less detected<br/>
        /// Example: [en]
        /// </param>
        /// <param name="sentences">
        /// If `sentences` has been enabled, sentences results for this translation
        /// </param>
        /// <param name="subtitles">
        /// If `subtitles` has been enabled, subtitles results for this translation
        /// </param>
        /// <param name="utterances">
        /// Transcribed speech utterances present in the audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationResultDTO(
            string fullTranscript,
            global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum> languages,
            global::System.Collections.Generic.IList<global::Gladia.UtteranceDTO> utterances,
            global::Gladia.AddonErrorDTO? error,
            global::System.Collections.Generic.IList<global::Gladia.SentencesDTO>? sentences,
            global::System.Collections.Generic.IList<global::Gladia.SubtitleDTO>? subtitles)
        {
            this.FullTranscript = fullTranscript ?? throw new global::System.ArgumentNullException(nameof(fullTranscript));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Utterances = utterances ?? throw new global::System.ArgumentNullException(nameof(utterances));
            this.Error = error;
            this.Sentences = sentences;
            this.Subtitles = subtitles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResultDTO" /> class.
        /// </summary>
        public TranslationResultDTO()
        {
        }
    }
}