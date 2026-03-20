#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookLiveEndRecordingPayloadEventNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.WebhookLiveEndRecordingPayloadEvent?>
    {
        /// <inheritdoc />
        public override global::Gladia.WebhookLiveEndRecordingPayloadEvent? Read(
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
                        return global::Gladia.WebhookLiveEndRecordingPayloadEventExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.WebhookLiveEndRecordingPayloadEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.WebhookLiveEndRecordingPayloadEvent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.WebhookLiveEndRecordingPayloadEvent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gladia.WebhookLiveEndRecordingPayloadEventExtensions.ToValueString(value.Value));
            }
        }
    }
}
