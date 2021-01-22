using System;
using System.ComponentModel;
using System.Threading.Tasks;
using FluentAssertions;
using Securancy.Labs.KvkApi.Models;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests
{
    public class SearchCompaniesTests : BaseTests
    {
        [Fact, Category("Integration")]
        public async Task SearchCompanies_Should_Success()
        {
            var client = new KvkApiClient(_config);
            var request = new SearchCompaniesParameters()
            {
                Query = "test"
            };
            var target = await client.SearchCompanies(request);
            target.Should().NotBeNull();
            target.Addresses.Should().NotBeNullOrEmpty();
        }
        
        [Fact, Category("Integration")]
        public async Task TestSearchCompanies_Should_Success()
        {
            var client = new KvkApiClient(_config);
            var target = await client.TestSearchCompanies();
            target.Should().NotBeNull();
        }
        
        [Fact, Category("Integration")]
        public async Task TestSearchProfiles_Should_Success()
        {
            var client = new KvkApiClient(_config);
            var target = await client.TestSearchProfiles();
            target.Should().NotBeNull();
        }
    }
}