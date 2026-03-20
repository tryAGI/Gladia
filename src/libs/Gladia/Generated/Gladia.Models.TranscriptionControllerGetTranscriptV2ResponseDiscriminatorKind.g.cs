
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        PreRecorded,
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind value)
        {
            return value switch
            {
                TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.PreRecorded => "pre-recorded",
                TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "pre-recorded" => TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.PreRecorded,
                "live" => TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.Live,
                _ => null,
            };
        }
    }
}