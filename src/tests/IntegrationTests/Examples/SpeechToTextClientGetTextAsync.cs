/*
order: 20
title: Speech To Text Client Get Text Async
slug: speech-to-text-client-get-text-async
*/

using Microsoft.Extensions.AI;

namespace Gladia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetTextAsync()
    {
        using var api = GetAuthenticatedClient();
        ISpeechToTextClient speechClient = api;

        //// Transcribe audio using the MEAI ISpeechToTextClient interface.
        //// The client uploads the audio stream and polls until transcription is complete.
        using var httpClient = new HttpClient();
        await using var audioStream = await httpClient.GetStreamAsync(
            "https://cdn.openai.com/API/docs/audio/alloy.wav");

        var ms = new MemoryStream();
        await audioStream.CopyToAsync(ms);
        ms.Position = 0;

        var response = await speechClient.GetTextAsync(ms);

        Console.WriteLine($"Text: {response.Text}");

        Assert.IsNotNull(response.Text);
        Assert.IsTrue(response.Text.Length > 0);
        Assert.IsNotNull(response.RawRepresentation);
    }
}
