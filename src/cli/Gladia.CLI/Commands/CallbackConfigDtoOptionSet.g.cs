#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record CallbackConfigDtoOptionSet(
    Option<string> Url,
                     Option<global::Gladia.CallbackMethodEnum?> Method)
{
    public static CallbackConfigDtoOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CallbackConfigDtoOptionSet(
                        Url: new Option<string>($"--{normalizedPrefix}url")
                {
                    Description = @"The URL to be called with the result of the transcription",
                    Required = true,
                },
                Method: new Option<global::Gladia.CallbackMethodEnum?>($"--{normalizedPrefix}method")
                {
                    Description = @"The HTTP method to be used. Allowed values are `POST` or `PUT` (default: `POST`)",
                }
        );
    }
}