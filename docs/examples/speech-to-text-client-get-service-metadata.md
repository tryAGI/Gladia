# Speech To Text Client Get Service Metadata



This example assumes `using Gladia;` is in scope and `apiKey` contains your Gladia API key.

```csharp
using var api = new GladiaClient("dummy-key");
ISpeechToTextClient speechClient = api;

// Retrieve metadata about the speech-to-text provider.
var metadata = speechClient.GetService<SpeechToTextClientMetadata>();
```