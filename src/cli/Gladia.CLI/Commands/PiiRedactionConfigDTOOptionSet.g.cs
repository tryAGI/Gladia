#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record PiiRedactionConfigDTOOptionSet(
    Option<global::System.Collections.Generic.IList<global::Gladia.PiiRedactionEntityTypeEnum>?> EntityTypes,
                     Option<global::Gladia.PiiRedactionConfigDTOProcessedTextType?> ProcessedTextType)
{
    public static PiiRedactionConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PiiRedactionConfigDTOOptionSet(
                        EntityTypes: new Option<global::System.Collections.Generic.IList<global::Gladia.PiiRedactionEntityTypeEnum>?>($"--{normalizedPrefix}entity-types")
                {
                    Description = @"The presets and entity types to redact. When omitted or empty, the full default detection set is redacted. When non-empty, only the listed presets and entity types are redacted (not the default set plus these). Each preset covers different entity types: for instance `HEALTH_INFORMATION` only covers clinical content and does not redact names, contact details or SSN, which `HIPAA_SAFE_HARBOR` does. See https://docs.gladia.io/chapters/audio-intelligence/pii-redaction for the content of each preset.",
                },
                ProcessedTextType: new Option<global::Gladia.PiiRedactionConfigDTOProcessedTextType?>($"--{normalizedPrefix}processed-text-type")
                {
                    Description = @"The type of processed text to return (marker or mask)",
                }
        );
    }
}