
#nullable enable

namespace Gladia
{
    /// <summary>
    /// "queued": the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
    /// </summary>
    public enum StreamingResponseStatus
    {
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Queued,
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Processing,
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Done,
        /// <summary>
        /// the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingResponseStatus value)
        {
            return value switch
            {
                StreamingResponseStatus.Queued => "queued",
                StreamingResponseStatus.Processing => "processing",
                StreamingResponseStatus.Done => "done",
                StreamingResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => StreamingResponseStatus.Queued,
                "processing" => StreamingResponseStatus.Processing,
                "done" => StreamingResponseStatus.Done,
                "error" => StreamingResponseStatus.Error,
                _ => null,
            };
        }
    }
}