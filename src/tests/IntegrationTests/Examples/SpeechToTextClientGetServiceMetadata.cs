/*
order: 30
title: Speech To Text Client Get Service Metadata
slug: speech-to-text-client-get-service-metadata
*/

using Microsoft.Extensions.AI;

namespace Gladia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_GetService_Metadata()
    {
        using var api = new GladiaClient("dummy-key");
        ISpeechToTextClient speechClient = api;

        //// Retrieve metadata about the speech-to-text provider.
        var metadata = speechClient.GetService<SpeechToTextClientMetadata>();

        Assert.IsNotNull(metadata);
        Assert.AreEqual("gladia", metadata.ProviderName);
        Assert.IsNotNull(metadata.ProviderUri);
    }
}
