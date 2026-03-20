
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionControllerListV2KindItem
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
    public static class TranscriptionControllerListV2KindItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionControllerListV2KindItem value)
        {
            return value switch
            {
                TranscriptionControllerListV2KindItem.PreRecorded => "pre-recorded",
                TranscriptionControllerListV2KindItem.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionControllerListV2KindItem? ToEnum(string value)
        {
            return value switch
            {
                "pre-recorded" => TranscriptionControllerListV2KindItem.PreRecorded,
                "live" => TranscriptionControllerListV2KindItem.Live,
                _ => null,
            };
        }
    }
}