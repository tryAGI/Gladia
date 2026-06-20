#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal sealed record InitTranscriptionRequestOptionSet(
    Option<bool?> CustomVocabulary,
                     Option<string?> CallbackUrl,
                     Option<bool?> Callback,
                     Option<bool?> Subtitles,
                     Option<bool?> Diarization,
                     Option<bool?> Translation,
                     Option<bool?> Summarization,
                     Option<bool?> NamedEntityRecognition,
                     Option<bool?> CustomSpelling,
                     Option<bool?> SentimentAnalysis,
                     Option<bool?> AudioToLlm,
                     Option<bool?> PiiRedaction,
                     Option<bool?> Sentences,
                     Option<bool?> PunctuationEnhanced,
                     Option<string> AudioUrl,
                     Option<global::Gladia.PreRecordedTranscriptionModel?> Model)
{
    public static InitTranscriptionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new InitTranscriptionRequestOptionSet(
                        CustomVocabulary: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}custom-vocabulary", description: @"**[Beta]** Can be either boolean to enable custom_vocabulary for this audio or an array with specific vocabulary list to feed the transcription model with"),
                CallbackUrl: new Option<string?>($"--{normalizedPrefix}callback-url")
                {
                    Description = @"**[Deprecated]** Use `callback`/`callback_config` instead. Callback URL we will do a `POST` request to with the result of the transcription",
                },
                Callback: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}callback", description: @"Enable callback for this transcription. If true, the `callback_config` property will be used to customize the callback behaviour"),
                Subtitles: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}subtitles", description: @"Enable subtitles generation for this transcription"),
                Diarization: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}diarization", description: @"Enable speaker recognition (diarization) for this audio"),
                Translation: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}translation", description: @"**[Beta]** Enable translation for this audio"),
                Summarization: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}summarization", description: @"Enable summarization for this audio"),
                NamedEntityRecognition: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}named-entity-recognition", description: @"**[Alpha]** Enable named entity recognition for this audio"),
                CustomSpelling: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}custom-spelling", description: @"**[Alpha]** Enable custom spelling for this audio"),
                SentimentAnalysis: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}sentiment-analysis", description: @"Enable sentiment analysis for this audio"),
                AudioToLlm: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}audio-to-llm", description: @"Enable audio to LLM processing for this audio"),
                PiiRedaction: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}pii-redaction", description: @"Enable PII redaction for this audio"),
                Sentences: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}sentences", description: @"Enable sentences for this audio"),
                PunctuationEnhanced: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}punctuation-enhanced", description: @"**[Alpha]** Use enhanced punctuation for this audio"),
                AudioUrl: new Option<string>($"--{normalizedPrefix}audio-url")
                {
                    Description = @"URL to a Gladia file or to an external audio or video file",
                    Required = true,
                },
                Model: new Option<global::Gladia.PreRecordedTranscriptionModel?>($"--{normalizedPrefix}model")
                {
                    Description = @"The model used to process the audio. ""solaria-1"" is used by default. ""solaria-3"" is async pre-recorded only and requires exactly one language in language_config.languages.",
                }
        );
    }
}