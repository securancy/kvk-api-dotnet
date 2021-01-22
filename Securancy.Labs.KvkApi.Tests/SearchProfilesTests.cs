using System;
using System.ComponentModel;
using System.Threading.Tasks;
using FluentAssertions;
using Securancy.Labs.KvkApi.Models;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests
{
    public class SearchProfilesTests : BaseTests
    {
        [Fact, Category("Integration")]
        public async Task TestSearchProfiles_Should_Success()
        {
            var client = new KvkApiClient(_config);
            var target = await client.TestSearchProfiles();
            target.Should().NotBeNull();
        }
        
        [Fact, Category("Integration")]
        public async Task SearchProfiles_Should_Success()
        {
            var expectedName = "test";
            var client = new KvkApiClient(_config);
            var request = new SearchProfileParameters()
            {
                Query = expectedName
            };
            var target = await client.SearchProfiles(request);
            target.Should().NotBeNull();
            target.Data.Items.Count.Should().BeGreaterOrEqualTo(1);

            foreach (var result in target.Data.Items)
            {
                result.TradeNames.BusinessName.ToLowerInvariant().Should().Contain(expectedName.ToLowerInvariant());
            }
        }
    }
}