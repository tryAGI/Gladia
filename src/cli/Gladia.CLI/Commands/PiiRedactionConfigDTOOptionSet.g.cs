#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record PiiRedactionConfigDTOOptionSet(
    Option<global::Gladia.PiiRedactionEntityTypeEnum?> EntityTypes,
                     Option<global::Gladia.PiiRedactionConfigDTOProcessedTextType?> ProcessedTextType)
{
    public static PiiRedactionConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PiiRedactionConfigDTOOptionSet(
                        EntityTypes: new Option<global::Gladia.PiiRedactionEntityTypeEnum?>($"--{normalizedPrefix}entity-types")
                {
                    Description = @"The entity types to redact",
                },
                ProcessedTextType: new Option<global::Gladia.PiiRedactionConfigDTOProcessedTextType?>($"--{normalizedPrefix}processed-text-type")
                {
                    Description = @"The type of processed text to return (marker or mask)",
                }
        );
    }
}