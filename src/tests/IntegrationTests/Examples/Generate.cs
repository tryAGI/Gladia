/*
order: 10
title: List Transcription Jobs
slug: list-transcription-jobs

List pre-recorded transcription jobs.
*/

namespace Gladia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListTranscriptionJobs()
    {
        using var client = GetAuthenticatedClient();

        //// List recent pre-recorded transcription jobs.
        var response = await client.PreRecordedV2.PreRecordedControllerGetPreRecordedJobsV2Async(
            limit: 10);

        Assert.IsNotNull(response);
    }
}
