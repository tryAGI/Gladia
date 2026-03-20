
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookLiveEndRecordingPayload
    {
        /// <summary>
        /// Default Value: live.end_recording<br/>
        /// Example: live.end_recording
        /// </summary>
        /// <default>global::Gladia.WebhookLiveEndRecordingPayloadEvent.LiveEndRecording</default>
        /// <example>live.end_recording</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.WebhookLiveEndRecordingPayloadEventJsonConverter))]
        public global::Gladia.WebhookLiveEndRecordingPayloadEvent Event { get; set; } = global::Gladia.WebhookLiveEndRecordingPayloadEvent.LiveEndRecording;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Gladia.LiveEventPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveEndRecordingPayload" /> class.
        /// </summary>
        /// <param name="event">
        /// Default Value: live.end_recording<br/>
        /// Example: live.end_recording
        /// </param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLiveEndRecordingPayload(
            global::Gladia.LiveEventPayload payload,
            global::Gladia.WebhookLiveEndRecordingPayloadEvent @event = global::Gladia.WebhookLiveEndRecordingPayloadEvent.LiveEndRecording)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveEndRecordingPayload" /> class.
        /// </summary>
        public WebhookLiveEndRecordingPayload()
        {
        }
    }
}