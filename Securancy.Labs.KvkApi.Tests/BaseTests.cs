using Microsoft.Extensions.Configuration;

namespace Securancy.Labs.KvkApi.Tests;

public abstract class BaseTests
{
    protected BaseTests()
    {
        var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true);
        var configuration = builder.Build();
        configuration.GetRequiredSection("KvkApiSettings").Bind(Config);
    }

    protected readonly KvkApiClientConfig Config = new();
}