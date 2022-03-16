namespace Securancy.Labs.KvkApi.Tests;

public abstract class BaseTests
{
    protected readonly KvkApiClientConfig Config = new()
    {
        Endpoint = "",
        ApiKey = ""
    };
}