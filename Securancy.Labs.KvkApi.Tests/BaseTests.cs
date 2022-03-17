namespace Securancy.Labs.KvkApi.Tests;

public abstract class BaseTests
{
    protected readonly KvkApiClientConfig Config = new()
    {
        Endpoint = "https://api.securancy.io/services/kvk",
        ApiKey = "6b3fdfb43e59461fafcf184df13f6f35"
    };
}