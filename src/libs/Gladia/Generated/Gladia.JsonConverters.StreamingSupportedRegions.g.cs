#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class StreamingSupportedRegionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.StreamingSupportedRegions>
    {
        /// <inheritdoc />
        public override global::Gladia.StreamingSupportedRegions Read(
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
                        return global::Gladia.StreamingSupportedRegionsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.StreamingSupportedRegions)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.StreamingSupportedRegions);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.StreamingSupportedRegions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gladia.StreamingSupportedRegionsExtensions.ToValueString(value));
        }
    }
}
