#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallbackLivePostFinalTranscriptMessageEventNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.CallbackLivePostFinalTranscriptMessageEvent?>
    {
        /// <inheritdoc />
        public override global::Gladia.CallbackLivePostFinalTranscriptMessageEvent? Read(
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
                        return global::Gladia.CallbackLivePostFinalTranscriptMessageEventExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.CallbackLivePostFinalTranscriptMessageEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.CallbackLivePostFinalTranscriptMessageEvent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.CallbackLivePostFinalTranscriptMessageEvent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gladia.CallbackLivePostFinalTranscriptMessageEventExtensions.ToValueString(value.Value));
            }
        }
    }
}
