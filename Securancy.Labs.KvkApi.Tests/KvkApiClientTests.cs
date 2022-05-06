using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests;

public class KvkApiClientTests : BaseTests
{
    [Fact]
    public void ConstructorTest()
    {
        using var client = new HttpClient();
        var target = new ZoekenKvkApiClient(Config, client);
        target.Should().NotBeNull();
    }
        
    [Fact]
    public void ConstructorShouldFailWithNullConfig()
    {
        Assert.Throws<ArgumentNullException>(() => new ZoekenKvkApiClient(null, null));
    }
}