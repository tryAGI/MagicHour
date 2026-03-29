namespace MagicHour.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MagicHourClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MAGICHOUR_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MAGICHOUR_API_KEY environment variable is not found.");

        var client = new MagicHourClient(apiKey);
        
        return client;
    }
}
