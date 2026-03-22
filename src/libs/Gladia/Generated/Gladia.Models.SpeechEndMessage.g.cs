
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechEndMessage
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
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Default Value: speech_end<br/>
        /// Example: speech_end
        /// </summary>
        /// <default>global::Gladia.SpeechEndMessageType.SpeechEnd</default>
        /// <example>speech_end</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.SpeechEndMessageTypeJsonConverter))]
        public global::Gladia.SpeechEndMessageType Type { get; set; } = global::Gladia.SpeechEndMessageType.SpeechEnd;

        /// <summary>
        /// The message data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Gladia.SpeechMessageData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEndMessage" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Id of the live session<br/>
        /// Example: 4a39145c-2844-4557-8f34-34883f7be7d9
        /// </param>
        /// <param name="createdAt">
        /// Date of creation of the message. The date is formatted as an ISO 8601 string<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="type">
        /// Default Value: speech_end<br/>
        /// Example: speech_end
        /// </param>
        /// <param name="data">
        /// The message data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechEndMessage(
            string sessionId,
            string createdAt,
            global::Gladia.SpeechMessageData data,
            global::Gladia.SpeechEndMessageType type = global::Gladia.SpeechEndMessageType.SpeechEnd)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEndMessage" /> class.
        /// </summary>
        public SpeechEndMessage()
        {
        }
    }
}