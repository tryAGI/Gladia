
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSwitchingConfigDTO
    {
        /// <summary>
        /// Specify the languages you want to use when detecting multiple languages<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSwitchingConfigDTO" /> class.
        /// </summary>
        /// <param name="languages">
        /// Specify the languages you want to use when detecting multiple languages<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSwitchingConfigDTO(
            global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>? languages)
        {
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSwitchingConfigDTO" /> class.
        /// </summary>
        public CodeSwitchingConfigDTO()
        {
        }
    }
}