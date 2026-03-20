/*
order: 40
title: Speech To Text Client Get Service Self
slug: speech-to-text-client-get-service-self
*/

using Microsoft.Extensions.AI;

namespace Gladia.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_GetService_Self()
    {
        using var api = new GladiaClient("dummy-key");
        ISpeechToTextClient speechClient = api;

        //// Access the underlying GladiaClient from the MEAI interface.
        var self = speechClient.GetService<GladiaClient>();

        Assert.IsNotNull(self);
        Assert.AreSame(api, self);
    }
}
