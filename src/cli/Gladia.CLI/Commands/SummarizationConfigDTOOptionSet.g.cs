#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record SummarizationConfigDTOOptionSet(
    Option<global::Gladia.SummaryTypesEnum?> Type)
{
    public static SummarizationConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SummarizationConfigDTOOptionSet(
                        Type: new Option<global::Gladia.SummaryTypesEnum?>($"--{normalizedPrefix}type")
                {
                    Description = @"The type of summarization to apply",
                }
        );
    }
}