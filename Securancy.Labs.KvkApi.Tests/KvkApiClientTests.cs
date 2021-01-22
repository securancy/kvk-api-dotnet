using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests
{
    public class KvkApiClientTests : BaseTests
    {
        [Fact]
        public void ConstructorTest()
        {
            var target = new KvkApiClient(_config);
            target.Should().NotBeNull();
        }
        
        [Fact]
        public void ConstructorShouldFailWithNullConfig()
        {
            Assert.Throws<ArgumentNullException>(() => new KvkApiClient(config: null));
        }
        
        [Fact]
        public async Task SslTestShouldSucceed()
        {
            var client = new KvkApiClient(_config);
            await client.SslTest();
        }
    }
}