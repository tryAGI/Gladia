
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreRecordedControllerGetPreRecordedJobsV2Statu
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
    public static class PreRecordedControllerGetPreRecordedJobsV2StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreRecordedControllerGetPreRecordedJobsV2Statu value)
        {
            return value switch
            {
                PreRecordedControllerGetPreRecordedJobsV2Statu.Queued => "queued",
                PreRecordedControllerGetPreRecordedJobsV2Statu.Processing => "processing",
                PreRecordedControllerGetPreRecordedJobsV2Statu.Done => "done",
                PreRecordedControllerGetPreRecordedJobsV2Statu.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreRecordedControllerGetPreRecordedJobsV2Statu? ToEnum(string value)
        {
            return value switch
            {
                "queued" => PreRecordedControllerGetPreRecordedJobsV2Statu.Queued,
                "processing" => PreRecordedControllerGetPreRecordedJobsV2Statu.Processing,
                "done" => PreRecordedControllerGetPreRecordedJobsV2Statu.Done,
                "error" => PreRecordedControllerGetPreRecordedJobsV2Statu.Error,
                _ => null,
            };
        }
    }
}