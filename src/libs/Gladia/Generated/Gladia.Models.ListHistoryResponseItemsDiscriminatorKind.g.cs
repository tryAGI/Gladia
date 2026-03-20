
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListHistoryResponseItemsDiscriminatorKind
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
    public static class ListHistoryResponseItemsDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListHistoryResponseItemsDiscriminatorKind value)
        {
            return value switch
            {
                ListHistoryResponseItemsDiscriminatorKind.PreRecorded => "pre-recorded",
                ListHistoryResponseItemsDiscriminatorKind.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListHistoryResponseItemsDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "pre-recorded" => ListHistoryResponseItemsDiscriminatorKind.PreRecorded,
                "live" => ListHistoryResponseItemsDiscriminatorKind.Live,
                _ => null,
            };
        }
    }
}