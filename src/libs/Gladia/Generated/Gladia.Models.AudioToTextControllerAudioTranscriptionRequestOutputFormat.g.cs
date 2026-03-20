
#nullable enable

namespace Gladia
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum AudioToTextControllerAudioTranscriptionRequestOutputFormat
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
    public static class AudioToTextControllerAudioTranscriptionRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToTextControllerAudioTranscriptionRequestOutputFormat value)
        {
            return value switch
            {
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Json => "json",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Srt => "srt",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Vtt => "vtt",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Plain => "plain",
                AudioToTextControllerAudioTranscriptionRequestOutputFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToTextControllerAudioTranscriptionRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Json,
                "srt" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Srt,
                "vtt" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Vtt,
                "plain" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Plain,
                "txt" => AudioToTextControllerAudioTranscriptionRequestOutputFormat.Txt,
                _ => null,
            };
        }
    }
}