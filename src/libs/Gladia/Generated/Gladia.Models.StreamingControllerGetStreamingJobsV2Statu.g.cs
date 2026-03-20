
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingControllerGetStreamingJobsV2Statu
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
    public static class StreamingControllerGetStreamingJobsV2StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingControllerGetStreamingJobsV2Statu value)
        {
            return value switch
            {
                StreamingControllerGetStreamingJobsV2Statu.Queued => "queued",
                StreamingControllerGetStreamingJobsV2Statu.Processing => "processing",
                StreamingControllerGetStreamingJobsV2Statu.Done => "done",
                StreamingControllerGetStreamingJobsV2Statu.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingControllerGetStreamingJobsV2Statu? ToEnum(string value)
        {
            return value switch
            {
                "queued" => StreamingControllerGetStreamingJobsV2Statu.Queued,
                "processing" => StreamingControllerGetStreamingJobsV2Statu.Processing,
                "done" => StreamingControllerGetStreamingJobsV2Statu.Done,
                "error" => StreamingControllerGetStreamingJobsV2Statu.Error,
                _ => null,
            };
        }
    }
}