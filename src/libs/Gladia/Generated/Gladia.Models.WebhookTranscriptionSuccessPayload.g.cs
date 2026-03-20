
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTranscriptionSuccessPayload
    {
        /// <summary>
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </summary>
        /// <default>global::Gladia.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess</default>
        /// <example>transcription.success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.WebhookTranscriptionSuccessPayloadEventJsonConverter))]
        public global::Gladia.WebhookTranscriptionSuccessPayloadEvent Event { get; set; } = global::Gladia.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Gladia.PreRecordedEventPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionSuccessPayload" /> class.
        /// </summary>
        /// <param name="event">
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTranscriptionSuccessPayload(
            global::Gladia.PreRecordedEventPayload payload,
            global::Gladia.WebhookTranscriptionSuccessPayloadEvent @event = global::Gladia.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionSuccessPayload" /> class.
        /// </summary>
        public WebhookTranscriptionSuccessPayload()
        {
        }
    }
}