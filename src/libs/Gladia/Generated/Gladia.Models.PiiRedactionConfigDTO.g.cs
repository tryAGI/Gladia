
#nullable enable

namespace Gladia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PiiRedactionConfigDTO
    {
        /// <summary>
        /// The presets and entity types to redact. When omitted or empty, the full default detection set is redacted. When non-empty, only the listed presets and entity types are redacted (not the default set plus these). Each preset covers different entity types: for instance `HEALTH_INFORMATION` only covers clinical content and does not redact names, contact details or SSN, which `HIPAA_SAFE_HARBOR` does. See https://docs.gladia.io/chapters/audio-intelligence/pii-redaction for the content of each preset.<br/>
        /// Example: [GDPR]
        /// </summary>
        /// <example>[GDPR]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_types")]
        public global::System.Collections.Generic.IList<global::Gladia.PiiRedactionEntityTypeEnum>? EntityTypes { get; set; }

        /// <summary>
        /// The type of processed text to return (marker or mask)<br/>
        /// Example: MARKER
        /// </summary>
        /// <example>MARKER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_text_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gladia.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeJsonConverter))]
        public global::Gladia.PiiRedactionConfigDTOProcessedTextType? ProcessedTextType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiRedactionConfigDTO" /> class.
        /// </summary>
        /// <param name="entityTypes">
        /// The presets and entity types to redact. When omitted or empty, the full default detection set is redacted. When non-empty, only the listed presets and entity types are redacted (not the default set plus these). Each preset covers different entity types: for instance `HEALTH_INFORMATION` only covers clinical content and does not redact names, contact details or SSN, which `HIPAA_SAFE_HARBOR` does. See https://docs.gladia.io/chapters/audio-intelligence/pii-redaction for the content of each preset.<br/>
        /// Example: [GDPR]
        /// </param>
        /// <param name="processedTextType">
        /// The type of processed text to return (marker or mask)<br/>
        /// Example: MARKER
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiiRedactionConfigDTO(
            global::System.Collections.Generic.IList<global::Gladia.PiiRedactionEntityTypeEnum>? entityTypes,
            global::Gladia.PiiRedactionConfigDTOProcessedTextType? processedTextType)
        {
            this.EntityTypes = entityTypes;
            this.ProcessedTextType = processedTextType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiRedactionConfigDTO" /> class.
        /// </summary>
        public PiiRedactionConfigDTO()
        {
        }

    }
}