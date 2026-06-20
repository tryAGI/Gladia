/*
order: 40
title: Pre-Recorded Solaria-3 Model
slug: pre-recorded-solaria-3-model

Configure a pre-recorded transcription request to use Solaria-3.
*/

using System.Text.Json;

namespace Gladia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void PreRecorded_Solaria3Model_Serializes()
    {
        var request = new InitTranscriptionRequest
        {
            AudioUrl = "https://cdn.openai.com/API/docs/audio/alloy.wav",
            Model = PreRecordedTranscriptionModel.Solaria3,
            LanguageConfig = new LanguageConfig
            {
                Languages = [TranscriptionLanguageCodeEnum.En],
                CodeSwitching = false,
            },
        };

        //// Solaria-3 is available for async pre-recorded transcription only.
        //// Use one supported language and keep code switching disabled.
        var json = request.ToJson(SourceGenerationContext.Default);
        using var document = JsonDocument.Parse(json);

        Assert.AreEqual(
            "solaria-3",
            document.RootElement.GetProperty("model").GetString());
        Assert.AreEqual(
            "en",
            document.RootElement
                .GetProperty("language_config")
                .GetProperty("languages")[0]
                .GetString());
    }

    [TestMethod]
    public async Task PreRecorded_Solaria3Model_CreatesJob()
    {
        using var client = GetAuthenticatedClient();

        var job = await client.PreRecordedV2.PreRecordedControllerInitPreRecordedJobV2Async(
            new InitTranscriptionRequest
            {
                AudioUrl = "https://cdn.openai.com/API/docs/audio/alloy.wav",
                Model = PreRecordedTranscriptionModel.Solaria3,
                LanguageConfig = new LanguageConfig
                {
                    Languages = [TranscriptionLanguageCodeEnum.En],
                    CodeSwitching = false,
                },
            });

        var response = await client.PreRecordedV2.PreRecordedControllerGetPreRecordedJobV2Async(
            job.Id.ToString());

        Assert.AreNotEqual(Guid.Empty, job.Id);
        Assert.AreEqual(PreRecordedTranscriptionModel.Solaria3, response.RequestParams?.Model);
    }
}
