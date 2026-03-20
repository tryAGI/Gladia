
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum HistoryControllerGetListV1KindItem
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
    public static class HistoryControllerGetListV1KindItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryControllerGetListV1KindItem value)
        {
            return value switch
            {
                HistoryControllerGetListV1KindItem.PreRecorded => "pre-recorded",
                HistoryControllerGetListV1KindItem.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryControllerGetListV1KindItem? ToEnum(string value)
        {
            return value switch
            {
                "pre-recorded" => HistoryControllerGetListV1KindItem.PreRecorded,
                "live" => HistoryControllerGetListV1KindItem.Live,
                _ => null,
            };
        }
    }
}