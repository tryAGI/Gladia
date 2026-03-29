
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackTranscriptionErrorPayload
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Type of event<br/>
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </summary>
        /// <default>global::Gladia.CallbackTranscriptionErrorPayloadEvent.TranscriptionError</default>
        /// <example>transcription.error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.CallbackTranscriptionErrorPayloadEventJsonConverter))]
        public global::Gladia.CallbackTranscriptionErrorPayloadEvent Event { get; set; } = global::Gladia.CallbackTranscriptionErrorPayloadEvent.TranscriptionError;

        /// <summary>
        /// The error that occurred during the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Gladia.ErrorDTO Error { get; set; }

        /// <summary>
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackTranscriptionErrorPayload" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="error">
        /// The error that occurred during the transcription
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="event">
        /// Type of event<br/>
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackTranscriptionErrorPayload(
            global::System.Guid id,
            global::Gladia.ErrorDTO error,
            object? customMetadata,
            global::Gladia.CallbackTranscriptionErrorPayloadEvent @event = global::Gladia.CallbackTranscriptionErrorPayloadEvent.TranscriptionError)
        {
            this.Id = id;
            this.Event = @event;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.CustomMetadata = customMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackTranscriptionErrorPayload" /> class.
        /// </summary>
        public CallbackTranscriptionErrorPayload()
        {
        }
    }
}