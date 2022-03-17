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
        using var httpClient = new HttpClient();
        var client = new BasisprofielKvkApiClient(Config, httpClient);
        var target = await client.GetBasisprofielByKvkNummerAsync(expectedKvKNumber);
        target.Should().NotBeNull();
        target.KvkNummer.Should().BeEquivalentTo(expectedKvKNumber);
    }
}