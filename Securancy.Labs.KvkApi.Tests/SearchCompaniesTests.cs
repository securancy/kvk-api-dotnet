using System.ComponentModel;
using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests;

public class SearchCompaniesTests : BaseTests
{
    [Fact, Category("Integration")] 
    public async Task Search_Should_Succeed()
    {
        const string expectedName = "test";
        using var httpClient = new HttpClient();
        var client = new ZoekenKvkApiClient(Config, httpClient);
        var target = await client.GetResultsAsync(naam: expectedName);
        target.Should().NotBeNull();
        target.Resultaten.Count.Should().BeGreaterOrEqualTo(1);

        foreach (var result in target.Resultaten)
        {
            result.Naam.ToLowerInvariant().Should().Contain(expectedName.ToLowerInvariant());
        }
    }
}