using System.ComponentModel;
using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests;

public class SearchProfilesTests : BaseTests
{

    [Fact, Category("Integration")]
    public async Task SearchProfiles_Should_Success()
    {
        var expectedKvKNumber = "56701888";
        var client = new KvkApiClient(Config);
        var target = await client.SearchBasicProfile(expectedKvKNumber);
        target.Should().NotBeNull();
        target.KvkNummer.Should().BeEquivalentTo(expectedKvKNumber);
    }
}