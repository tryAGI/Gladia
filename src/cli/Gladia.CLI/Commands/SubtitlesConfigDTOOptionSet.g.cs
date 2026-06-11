#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record SubtitlesConfigDTOOptionSet(
    Option<global::System.Collections.Generic.IList<global::Gladia.SubtitlesFormatEnum>?> Formats,
                     Option<double?> MinimumDuration,
                     Option<double?> MaximumDuration,
                     Option<int?> MaximumCharactersPerRow,
                     Option<int?> MaximumRowsPerCaption,
                     Option<global::Gladia.SubtitlesStyleEnum?> Style)
{
    public static SubtitlesConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SubtitlesConfigDTOOptionSet(
                        Formats: new Option<global::System.Collections.Generic.IList<global::Gladia.SubtitlesFormatEnum>?>($"--{normalizedPrefix}formats")
                {
                    Description = @"Subtitles formats you want your transcription to be formatted to",
                },
                MinimumDuration: new Option<double?>($"--{normalizedPrefix}minimum-duration")
                {
                    Description = @"Minimum duration of a subtitle in seconds",
                },
                MaximumDuration: new Option<double?>($"--{normalizedPrefix}maximum-duration")
                {
                    Description = @"Maximum duration of a subtitle in seconds",
                },
                MaximumCharactersPerRow: new Option<int?>($"--{normalizedPrefix}maximum-characters-per-row")
                {
                    Description = @"Maximum number of characters per row in a subtitle",
                },
                MaximumRowsPerCaption: new Option<int?>($"--{normalizedPrefix}maximum-rows-per-caption")
                {
                    Description = @"Maximum number of rows per caption",
                },
                Style: new Option<global::Gladia.SubtitlesStyleEnum?>($"--{normalizedPrefix}style")
                {
                    Description = @"Style of the subtitles. Compliance mode refers to : https://loc.gov/preservation/digital/formats//fdd/fdd000569.shtml#:~:text=SRT%20files%20are%20basic%20text,alongside%2C%20example%3A%20%22MyVideo123",
                }
        );
    }
}