
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioToLlmListConfigDTO
    {
        /// <summary>
        /// The list of prompts applied on the audio transcription<br/>
        /// Example: [Extract the key points from the transcription]
        /// </summary>
        /// <example>[Extract the key points from the transcription]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Prompts { get; set; }

        /// <summary>
        /// The model to use for the prompt execution. You can find the list of supported models [here](https://openrouter.ai/models).<br/>
        /// Default Value: openai/gpt-3.5-turbo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToLlmListConfigDTO" /> class.
        /// </summary>
        /// <param name="prompts">
        /// The list of prompts applied on the audio transcription<br/>
        /// Example: [Extract the key points from the transcription]
        /// </param>
        /// <param name="model">
        /// The model to use for the prompt execution. You can find the list of supported models [here](https://openrouter.ai/models).<br/>
        /// Default Value: openai/gpt-3.5-turbo
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToLlmListConfigDTO(
            global::System.Collections.Generic.IList<byte[]> prompts,
            string? model)
        {
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToLlmListConfigDTO" /> class.
        /// </summary>
        public AudioToLlmListConfigDTO()
        {
        }
    }
}