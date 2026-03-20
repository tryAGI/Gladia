
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionControllerListV2Statu
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
    public static class TranscriptionControllerListV2StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionControllerListV2Statu value)
        {
            return value switch
            {
                TranscriptionControllerListV2Statu.Queued => "queued",
                TranscriptionControllerListV2Statu.Processing => "processing",
                TranscriptionControllerListV2Statu.Done => "done",
                TranscriptionControllerListV2Statu.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionControllerListV2Statu? ToEnum(string value)
        {
            return value switch
            {
                "queued" => TranscriptionControllerListV2Statu.Queued,
                "processing" => TranscriptionControllerListV2Statu.Processing,
                "done" => TranscriptionControllerListV2Statu.Done,
                "error" => TranscriptionControllerListV2Statu.Error,
                _ => null,
            };
        }
    }
}