#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallbackLivePostTranscriptMessageEventNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.CallbackLivePostTranscriptMessageEvent?>
    {
        /// <inheritdoc />
        public override global::Gladia.CallbackLivePostTranscriptMessageEvent? Read(
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
                        return global::Gladia.CallbackLivePostTranscriptMessageEventExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.CallbackLivePostTranscriptMessageEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.CallbackLivePostTranscriptMessageEvent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.CallbackLivePostTranscriptMessageEvent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gladia.CallbackLivePostTranscriptMessageEventExtensions.ToValueString(value.Value));
            }
        }
    }
}
