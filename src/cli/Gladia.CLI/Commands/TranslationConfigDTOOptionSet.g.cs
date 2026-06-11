#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record TranslationConfigDTOOptionSet(
    Option<global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum>> TargetLanguages,
                     Option<global::Gladia.TranslationModelEnum?> Model,
                     Option<bool?> MatchOriginalUtterances,
                     Option<bool?> Lipsync,
                     Option<bool?> ContextAdaptation,
                     Option<string?> Context,
                     Option<bool?> Informal)
{
    public static TranslationConfigDTOOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new TranslationConfigDTOOptionSet(
                        TargetLanguages: new Option<global::System.Collections.Generic.IList<global::Gladia.TranslationLanguageCodeEnum>>($"--{normalizedPrefix}target-languages")
                {
                    Description = @"Target language in `iso639-1` format you want the transcription translated to",
                    Required = true,
                },
                Model: new Option<global::Gladia.TranslationModelEnum?>($"--{normalizedPrefix}model")
                {
                    Description = @"Model you want the translation model to use to translate",
                },
                MatchOriginalUtterances: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}match-original-utterances", description: @"Align translated utterances with the original ones"),
                Lipsync: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}lipsync", description: @"Whether to apply lipsync to the translated transcription. "),
                ContextAdaptation: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}context-adaptation", description: @"Enables or disables context-aware translation features that allow the model to adapt translations based on provided context."),
                Context: new Option<string?>($"--{normalizedPrefix}context")
                {
                    Description = @"Context information to improve translation accuracy",
                },
                Informal: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}informal", description: @"Forces the translation to use informal language forms when available in the target language.")
        );
    }
}