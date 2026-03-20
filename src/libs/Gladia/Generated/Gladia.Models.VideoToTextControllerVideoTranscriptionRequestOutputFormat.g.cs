
#nullable enable

namespace Gladia
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum VideoToTextControllerVideoTranscriptionRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToTextControllerVideoTranscriptionRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToTextControllerVideoTranscriptionRequestOutputFormat value)
        {
            return value switch
            {
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Json => "json",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Srt => "srt",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Vtt => "vtt",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Plain => "plain",
                VideoToTextControllerVideoTranscriptionRequestOutputFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToTextControllerVideoTranscriptionRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Json,
                "srt" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Srt,
                "vtt" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Vtt,
                "plain" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Plain,
                "txt" => VideoToTextControllerVideoTranscriptionRequestOutputFormat.Txt,
                _ => null,
            };
        }
    }
}