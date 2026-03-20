namespace Gladia.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GladiaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GLADIA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("GLADIA_API_KEY environment variable is not found.");

        var client = new GladiaClient(apiKey);
        
        return client;
    }
}
