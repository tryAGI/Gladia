# List Transcription Jobs

List pre-recorded transcription jobs.

This example assumes `using Gladia;` is in scope and `apiKey` contains your Gladia API key.

```csharp
using var client = new GladiaClient(apiKey);

// List recent pre-recorded transcription jobs.
var response = await client.PreRecordedV2.PreRecordedControllerGetPreRecordedJobsV2Async(
    limit: 10);
```