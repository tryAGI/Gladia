#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallbackLiveTranscriptMessageEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.CallbackLiveTranscriptMessageEvent>
    {
        /// <inheritdoc />
        public override global::Gladia.CallbackLiveTranscriptMessageEvent Read(
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
                        return global::Gladia.CallbackLiveTranscriptMessageEventExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.CallbackLiveTranscriptMessageEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.CallbackLiveTranscriptMessageEvent);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.CallbackLiveTranscriptMessageEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gladia.CallbackLiveTranscriptMessageEventExtensions.ToValueString(value));
        }
    }
}
