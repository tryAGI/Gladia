
#nullable enable

namespace Gladia
{
    /// <summary>
    /// Style of the subtitles. Compliance mode refers to : https://loc.gov/preservation/digital/formats//fdd/fdd000569.shtml#:~:text=SRT%20files%20are%20basic%20text,alongside%2C%20example%3A%20%22MyVideo123 
    /// </summary>
    public enum SubtitlesStyleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Compliance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubtitlesStyleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubtitlesStyleEnum value)
        {
            return value switch
            {
                SubtitlesStyleEnum.Default => "default",
                SubtitlesStyleEnum.Compliance => "compliance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubtitlesStyleEnum? ToEnum(string value)
        {
            return value switch
            {
                "default" => SubtitlesStyleEnum.Default,
                "compliance" => SubtitlesStyleEnum.Compliance,
                _ => null,
            };
        }
    }
}