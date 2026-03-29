# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Gladia SDK implements `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `ISpeechToTextClient` | Full (file upload + async polling, 100+ languages) |

## ISpeechToTextClient

### Installation

```bash
dotnet add package Gladia
```

### File-Based Transcription

Transcribe an audio file to text. The client uploads the audio, initiates a transcription job, and polls until completion:

```csharp
using Gladia;
using Microsoft.Extensions.AI;

using var client = new GladiaClient(apiKey);
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.mp3");
var response = await sttClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
Console.WriteLine($"Duration: {response.StartTime} - {response.EndTime}");
```

### Transcription with Language Hint

Specify a language code for more accurate transcription:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("french-audio.mp3");
var response = await sttClient.GetTextAsync(audioStream, new SpeechToTextOptions
{
    SpeechLanguage = "fr",
});

Console.WriteLine(response.Text);
```

### Advanced Configuration with RawRepresentationFactory

Use `RawRepresentationFactory` to access Gladia-specific features like translation, diarization, and summarization:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.mp3");
var response = await sttClient.GetTextAsync(audioStream, new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new InitTranscriptionRequest
    {
        AudioUrl = "https://example.com/audio.mp3", // Use URL instead of upload
        Diarization = true,
        Translation = true,
        TranslationConfig = new TranslationConfigDTO
        {
            TargetLanguages = ["fr", "es"],
        },
    },
});

Console.WriteLine(response.Text);

// Access full Gladia response for advanced features
var raw = (PreRecordedResponse)response.RawRepresentation!;
Console.WriteLine($"Status: {raw.Status}");
```

### Streaming Behavior

`GetStreamingTextAsync` delegates to the non-streaming `GetTextAsync` method internally. The batch transcription job (upload + submit + poll) runs to completion first, and then the full result is converted to `SpeechToTextResponseUpdate` events using `ToSpeechToTextResponseUpdates()`.

This means you will not receive incremental transcription updates as audio is processed. The entire transcript is returned at once after the job finishes. For most use cases, calling `GetTextAsync` directly is equivalent and simpler.

!!! note
    Gladia does offer a live/streaming transcription API, but it is not exposed through the MEAI `ISpeechToTextClient` interface. Use the `GladiaClient` directly for real-time streaming needs.

### Accessing the Underlying Client

Retrieve the `GladiaClient` from the MEAI interface:

```csharp
ISpeechToTextClient sttClient = client;

var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "gladia"

var gladiaClient = sttClient.GetService<GladiaClient>();
// Use gladiaClient for Gladia-specific APIs (live streaming, file management, etc.)
```
