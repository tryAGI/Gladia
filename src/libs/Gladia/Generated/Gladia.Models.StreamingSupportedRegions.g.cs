
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingSupportedRegions
    {
        /// <summary>
        /// 
        /// </summary>
        UsWest,
        /// <summary>
        /// 
        /// </summary>
        EuWest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingSupportedRegionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingSupportedRegions value)
        {
            return value switch
            {
                StreamingSupportedRegions.UsWest => "us-west",
                StreamingSupportedRegions.EuWest => "eu-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingSupportedRegions? ToEnum(string value)
        {
            return value switch
            {
                "us-west" => StreamingSupportedRegions.UsWest,
                "eu-west" => StreamingSupportedRegions.EuWest,
                _ => null,
            };
        }
    }
}