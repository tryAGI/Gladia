#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookLiveEndSessionPayloadEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.WebhookLiveEndSessionPayloadEvent>
    {
        /// <inheritdoc />
        public override global::Gladia.WebhookLiveEndSessionPayloadEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Gladia.WebhookLiveEndSessionPayloadEventExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.WebhookLiveEndSessionPayloadEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.WebhookLiveEndSessionPayloadEvent);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.WebhookLiveEndSessionPayloadEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gladia.WebhookLiveEndSessionPayloadEventExtensions.ToValueString(value));
        }
    }
}
