
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum HistoryControllerGetListV1Statu
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HistoryControllerGetListV1StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryControllerGetListV1Statu value)
        {
            return value switch
            {
                HistoryControllerGetListV1Statu.Queued => "queued",
                HistoryControllerGetListV1Statu.Processing => "processing",
                HistoryControllerGetListV1Statu.Done => "done",
                HistoryControllerGetListV1Statu.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryControllerGetListV1Statu? ToEnum(string value)
        {
            return value switch
            {
                "queued" => HistoryControllerGetListV1Statu.Queued,
                "processing" => HistoryControllerGetListV1Statu.Processing,
                "done" => HistoryControllerGetListV1Statu.Done,
                "error" => HistoryControllerGetListV1Statu.Error,
                _ => null,
            };
        }
    }
}