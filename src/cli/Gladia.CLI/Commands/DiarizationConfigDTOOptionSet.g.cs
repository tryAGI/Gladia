#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record DiarizationConfigDTOOptionSet(
    Option<int?> NumberOfSpeakers,
                     Option<int?> MinSpeakers,
                     Option<int?> MaxSpeakers)
{
    public static DiarizationConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new DiarizationConfigDTOOptionSet(
                        NumberOfSpeakers: new Option<int?>($"--{normalizedPrefix}number-of-speakers")
                {
                    Description = @"Exact number of speakers in the audio",
                },
                MinSpeakers: new Option<int?>($"--{normalizedPrefix}min-speakers")
                {
                    Description = @"Minimum number of speakers in the audio",
                },
                MaxSpeakers: new Option<int?>($"--{normalizedPrefix}max-speakers")
                {
                    Description = @"Maximum number of speakers in the audio",
                }
        );
    }
}