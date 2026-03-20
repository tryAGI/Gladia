
#nullable enable

namespace Gladia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredDataExtractionConfigDTO
    {
        /// <summary>
        /// The list of classes to extract from the audio transcription<br/>
        /// Example: [Persons, Organizations]
        /// </summary>
        /// <example>[Persons, Organizations]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Classes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDataExtractionConfigDTO" /> class.
        /// </summary>
        /// <param name="classes">
        /// The list of classes to extract from the audio transcription<br/>
        /// Example: [Persons, Organizations]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredDataExtractionConfigDTO(
            global::System.Collections.Generic.IList<byte[]> classes)
        {
            this.Classes = classes ?? throw new global::System.ArgumentNullException(nameof(classes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDataExtractionConfigDTO" /> class.
        /// </summary>
        public StructuredDataExtractionConfigDTO()
        {
        }
    }
}