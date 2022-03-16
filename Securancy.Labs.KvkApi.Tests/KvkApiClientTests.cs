using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests;

public class KvkApiClientTests : BaseTests
{
    [Fact]
    public void ConstructorTest()
    {
        var target = new KvkApiClient(Config);
        target.Should().NotBeNull();
    }
        
    [Fact]
    public void ConstructorShouldFailWithNullConfig()
    {
        Assert.Throws<ArgumentNullException>(() => new KvkApiClient(config: null));
    }
}