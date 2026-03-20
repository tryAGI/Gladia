#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallbackLivePostChapterizationMessageEventNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.CallbackLivePostChapterizationMessageEvent?>
    {
        /// <inheritdoc />
        public override global::Gladia.CallbackLivePostChapterizationMessageEvent? Read(
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
                        return global::Gladia.CallbackLivePostChapterizationMessageEventExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.CallbackLivePostChapterizationMessageEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.CallbackLivePostChapterizationMessageEvent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.CallbackLivePostChapterizationMessageEvent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gladia.CallbackLivePostChapterizationMessageEventExtensions.ToValueString(value.Value));
            }
        }
    }
}
