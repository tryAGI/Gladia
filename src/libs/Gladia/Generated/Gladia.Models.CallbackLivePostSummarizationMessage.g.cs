
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackLivePostSummarizationMessage
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
        /// Default Value: live.post_summarization<br/>
        /// Example: live.post_summarization
        /// </summary>
        /// <default>global::Gladia.CallbackLivePostSummarizationMessageEvent.LivePostSummarization</default>
        /// <example>live.post_summarization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.CallbackLivePostSummarizationMessageEventJsonConverter))]
        public global::Gladia.CallbackLivePostSummarizationMessageEvent Event { get; set; } = global::Gladia.CallbackLivePostSummarizationMessageEvent.LivePostSummarization;

        /// <summary>
        /// The live message payload as sent to the WebSocket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Gladia.PostSummarizationMessage Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLivePostSummarizationMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="event">
        /// Default Value: live.post_summarization<br/>
        /// Example: live.post_summarization
        /// </param>
        /// <param name="payload">
        /// The live message payload as sent to the WebSocket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackLivePostSummarizationMessage(
            global::System.Guid id,
            global::Gladia.PostSummarizationMessage payload,
            global::Gladia.CallbackLivePostSummarizationMessageEvent @event = global::Gladia.CallbackLivePostSummarizationMessageEvent.LivePostSummarization)
        {
            this.Id = id;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLivePostSummarizationMessage" /> class.
        /// </summary>
        public CallbackLivePostSummarizationMessage()
        {
        }
    }
}