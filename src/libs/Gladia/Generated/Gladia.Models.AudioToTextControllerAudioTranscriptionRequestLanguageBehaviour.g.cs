
#nullable enable

namespace Gladia
{
    /// <summary>
    /// Default Value: automatic single language
    /// </summary>
    public enum AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour
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
    public static class AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour value)
        {
            return value switch
            {
                AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticSingleLanguage => "automatic single language",
                AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticMultipleLanguages => "automatic multiple languages",
                AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "automatic single language" => AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticSingleLanguage,
                "automatic multiple languages" => AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticMultipleLanguages,
                "manual" => AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.Manual,
                _ => null,
            };
        }
    }
}