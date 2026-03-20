# Speech To Text Client Get Service Self



This example assumes `using Gladia;` is in scope and `apiKey` contains your Gladia API key.

```csharp
using var api = new GladiaClient("dummy-key");
ISpeechToTextClient speechClient = api;

// Access the underlying GladiaClient from the MEAI interface.
var self = speechClient.GetService<GladiaClient>();
```