#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record LanguageConfigOptionSet(
    Option<global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>?> Languages,
                     Option<bool?> CodeSwitching)
{
    public static LanguageConfigOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new LanguageConfigOptionSet(
                        Languages: new Option<global::System.Collections.Generic.IList<global::Gladia.TranscriptionLanguageCodeEnum>?>($"--{normalizedPrefix}languages")
                {
                    Description = @"If one language is set, it will be used for the transcription. Otherwise, language will be auto-detected by the model.",
                },
                CodeSwitching: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}code-switching", description: @"If true, language will be auto-detected on each utterance. Otherwise, language will be auto-detected on first utterance and then used for the rest of the transcription. If one language is set, this option will be ignored.")
        );
    }
}