
#nullable enable

namespace Gladia
{
    /// <summary>
    /// The model used for async pre-recorded transcription.<br/>
    /// Default Value: solaria-1
    /// </summary>
    public enum PreRecordedTranscriptionModel
    {
        /// <summary>
        /// 
        /// </summary>
        Solaria1,
        /// <summary>
        /// 
        /// </summary>
        Solaria3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreRecordedTranscriptionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreRecordedTranscriptionModel value)
        {
            return value switch
            {
                PreRecordedTranscriptionModel.Solaria1 => "solaria-1",
                PreRecordedTranscriptionModel.Solaria3 => "solaria-3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreRecordedTranscriptionModel? ToEnum(string value)
        {
            return value switch
            {
                "solaria-1" => PreRecordedTranscriptionModel.Solaria1,
                "solaria-3" => PreRecordedTranscriptionModel.Solaria3,
                _ => null,
            };
        }
    }
}