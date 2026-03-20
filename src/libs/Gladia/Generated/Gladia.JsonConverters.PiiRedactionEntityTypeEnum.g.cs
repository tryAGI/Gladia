#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class PiiRedactionEntityTypeEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.PiiRedactionEntityTypeEnum>
    {
        /// <inheritdoc />
        public override global::Gladia.PiiRedactionEntityTypeEnum Read(
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
                        return global::Gladia.PiiRedactionEntityTypeEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.PiiRedactionEntityTypeEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.PiiRedactionEntityTypeEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.PiiRedactionEntityTypeEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gladia.PiiRedactionEntityTypeEnumExtensions.ToValueString(value));
        }
    }
}
