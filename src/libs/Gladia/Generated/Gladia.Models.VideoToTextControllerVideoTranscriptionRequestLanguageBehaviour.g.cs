
#nullable enable

namespace Gladia
{
    /// <summary>
    /// Default Value: automatic single language
    /// </summary>
    public enum VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        AutomaticSingleLanguage,
        /// <summary>
        /// 
        /// </summary>
        AutomaticMultipleLanguages,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour value)
        {
            return value switch
            {
                VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour.AutomaticSingleLanguage => "automatic single language",
                VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour.AutomaticMultipleLanguages => "automatic multiple languages",
                VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "automatic single language" => VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour.AutomaticSingleLanguage,
                "automatic multiple languages" => VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour.AutomaticMultipleLanguages,
                "manual" => VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour.Manual,
                _ => null,
            };
        }
    }
}