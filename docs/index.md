# Gladia

[![Nuget package](https://img.shields.io/nuget/vpre/Gladia)](https://www.nuget.org/packages/Gladia/)
[![dotnet](https://github.com/tryAGI/Gladia/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Gladia/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Gladia)](https://github.com/tryAGI/Gladia/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Gladia OpenAPI specification](https://raw.githubusercontent.com/Gladia/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Gladia;

using var client = new GladiaClient(apiKey);
```

<!-- EXAMPLES:START -->
### List Transcription Jobs
List pre-recorded transcription jobs.

```csharp
using var client = new GladiaClient(apiKey);

// List recent pre-recorded transcription jobs.
var response = await client.PreRecordedV2.PreRecordedControllerGetPreRecordedJobsV2Async(
    limit: 10);
```

### Speech To Text Client Get Text Async


```csharp
using var api = new GladiaClient(apiKey);
ISpeechToTextClient speechClient = api;

// Transcribe audio using the MEAI ISpeechToTextClient interface.
// The client uploads the audio stream and polls until transcription is complete.
using var httpClient = new HttpClient();
await using var audioStream = await httpClient.GetStreamAsync(
    "https://cdn.openai.com/API/docs/audio/alloy.wav");

var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);
ms.Position = 0;

var response = await speechClient.GetTextAsync(ms);

Console.WriteLine($"Text: {response.Text}");
```

### Speech To Text Client Get Service Metadata


```csharp
using var api = new GladiaClient("dummy-key");
ISpeechToTextClient speechClient = api;

// Retrieve metadata about the speech-to-text provider.
var metadata = speechClient.GetService<SpeechToTextClientMetadata>();
```

### Speech To Text Client Get Service Self


```csharp
using var api = new GladiaClient("dummy-key");
ISpeechToTextClient speechClient = api;

// Access the underlying GladiaClient from the MEAI interface.
var self = speechClient.GetService<GladiaClient>();
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Gladia/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Gladia/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).