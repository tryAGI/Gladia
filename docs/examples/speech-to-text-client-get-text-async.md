# Speech To Text Client Get Text Async



This example assumes `using Gladia;` is in scope and `apiKey` contains your Gladia API key.

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