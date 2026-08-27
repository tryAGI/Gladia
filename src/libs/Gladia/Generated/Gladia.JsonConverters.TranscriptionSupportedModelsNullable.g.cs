#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranscriptionSupportedModelsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.TranscriptionSupportedModels?>
    {
        /// <inheritdoc />
        public override global::Gladia.TranscriptionSupportedModels? Read(
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
                        return global::Gladia.TranscriptionSupportedModelsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.TranscriptionSupportedModels)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.TranscriptionSupportedModels?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.TranscriptionSupportedModels? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gladia.TranscriptionSupportedModelsExtensions.ToValueString(value.Value));
            }
        }
    }
}
