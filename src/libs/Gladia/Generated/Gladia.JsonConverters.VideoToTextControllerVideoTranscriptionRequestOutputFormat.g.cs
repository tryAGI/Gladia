#nullable enable

namespace Gladia.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoToTextControllerVideoTranscriptionRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat Read(
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
                        return global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gladia.VideoToTextControllerVideoTranscriptionRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
