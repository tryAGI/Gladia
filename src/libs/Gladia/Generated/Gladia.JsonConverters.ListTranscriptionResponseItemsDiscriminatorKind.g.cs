#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListTranscriptionResponseItemsDiscriminatorKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind>
    {
        /// <inheritdoc />
        public override global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind Read(
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
                        return global::Gladia.ListTranscriptionResponseItemsDiscriminatorKindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.ListTranscriptionResponseItemsDiscriminatorKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gladia.ListTranscriptionResponseItemsDiscriminatorKindExtensions.ToValueString(value));
        }
    }
}
