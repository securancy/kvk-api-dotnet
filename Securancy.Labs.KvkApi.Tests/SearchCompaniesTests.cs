using System.ComponentModel;
using FluentAssertions;
using Securancy.Labs.KvkApi.Models;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests;

public class SearchCompaniesTests : BaseTests
{
    [Fact, Category("Integration")]
    public async Task SearchCompanies_Should_Success()
    {
        var expectedName = "test";
        var client = new KvkApiClient(Config);
        var request = new SearchCompaniesParameters()
        {
            TradeName = expectedName
        };
        var target = await client.SearchCompanies(request);
        target.Should().NotBeNull();
        target.Resultaten.Count.Should().BeGreaterOrEqualTo(1);

        foreach (var result in target.Resultaten)
        {
            result.Handelsnaam.ToLowerInvariant().Should().Contain(expectedName.ToLowerInvariant());
        }
    }
}