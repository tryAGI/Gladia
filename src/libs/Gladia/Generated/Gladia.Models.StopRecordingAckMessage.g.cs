
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopRecordingAckMessage
    {
        /// <summary>
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </summary>
        /// <example>4a39145c-2844-4557-8f34-34883f7be7d9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2021-09-01T12:00:00.123Z
        /// </summary>
        /// <example>2021-09-01T12:00:00.123Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Flag to indicate if the action was successfully acknowledged<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Acknowledged { get; set; }

        /// <summary>
        /// Error message if the action was not successfully acknowledged<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Gladia.Error? Error { get; set; }

        /// <summary>
        /// Default Value: stop_recording<br/>
        /// Example: stop_recording
        /// </summary>
        /// <default>global::Gladia.StopRecordingAckMessageType.StopRecording</default>
        /// <example>stop_recording</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.StopRecordingAckMessageTypeJsonConverter))]
        public global::Gladia.StopRecordingAckMessageType Type { get; set; } = global::Gladia.StopRecordingAckMessageType.StopRecording;

        /// <summary>
        /// The message data. "null" if the action was not successfully acknowledged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Gladia.StopRecordingAckData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAckMessage" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        /// <param name="createdAt">
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2021-09-01T12:00:00.123Z
        /// </param>
        /// <param name="acknowledged">
        /// Flag to indicate if the action was successfully acknowledged<br/>
        /// Example: true
        /// </param>
        /// <param name="error">
        /// Error message if the action was not successfully acknowledged<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: stop_recording<br/>
        /// Example: stop_recording
        /// </param>
        /// <param name="data">
        /// The message data. "null" if the action was not successfully acknowledged
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopRecordingAckMessage(
            string sessionId,
            string createdAt,
            bool acknowledged,
            global::Gladia.Error? error,
            global::Gladia.StopRecordingAckData? data,
            global::Gladia.StopRecordingAckMessageType type = global::Gladia.StopRecordingAckMessageType.StopRecording)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Acknowledged = acknowledged;
            this.Error = error;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAckMessage" /> class.
        /// </summary>
        public StopRecordingAckMessage()
        {
        }
    }
}