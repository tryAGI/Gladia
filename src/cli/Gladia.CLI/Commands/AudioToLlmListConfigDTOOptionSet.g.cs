#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record AudioToLlmListConfigDTOOptionSet(
    Option<string?> Model)
{
    public static AudioToLlmListConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AudioToLlmListConfigDTOOptionSet(
                        Model: new Option<string?>($"--{normalizedPrefix}model")
                {
                    Description = @"The model to use for the prompt execution. You can find the list of supported models [here](https://openrouter.ai/models).",
                }
        );
    }
}