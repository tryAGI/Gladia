#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranscriptionControllerListV2StatuNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.TranscriptionControllerListV2Statu?>
    {
        /// <inheritdoc />
        public override global::Gladia.TranscriptionControllerListV2Statu? Read(
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
                        return global::Gladia.TranscriptionControllerListV2StatuExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.TranscriptionControllerListV2Statu)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.TranscriptionControllerListV2Statu?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.TranscriptionControllerListV2Statu? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gladia.TranscriptionControllerListV2StatuExtensions.ToValueString(value.Value));
            }
        }
    }
}
