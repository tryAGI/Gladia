#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record CustomVocabularyConfigDTOOptionSet(
    Option<double?> DefaultIntensity)
{
    public static CustomVocabularyConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CustomVocabularyConfigDTOOptionSet(
                        DefaultIntensity: new Option<double?>($"--{normalizedPrefix}default-intensity")
                {
                    Description = @"Default intensity for the custom vocabulary",
                }
        );
    }
}