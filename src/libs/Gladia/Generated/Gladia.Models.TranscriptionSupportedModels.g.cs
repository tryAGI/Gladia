
#nullable enable

namespace Gladia
{
    /// <summary>
    /// The model used to process the audio. "solaria-1" is used by default.
    /// </summary>
    public enum TranscriptionSupportedModels
    {
        /// <summary>
        /// 
        /// </summary>
        Solaria1,
        /// <summary>
        /// 
        /// </summary>
        Solaria3,
        /// <summary>
        /// 
        /// </summary>
        SolariaFusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionSupportedModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionSupportedModels value)
        {
            return value switch
            {
                TranscriptionSupportedModels.Solaria1 => "solaria-1",
                TranscriptionSupportedModels.Solaria3 => "solaria-3",
                TranscriptionSupportedModels.SolariaFusion => "solaria-fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionSupportedModels? ToEnum(string value)
        {
            return value switch
            {
                "solaria-1" => TranscriptionSupportedModels.Solaria1,
                "solaria-3" => TranscriptionSupportedModels.Solaria3,
                "solaria-fusion" => TranscriptionSupportedModels.SolariaFusion,
                _ => null,
            };
        }
    }
}