using System;
using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests
{
    public class KvkApiClientTests
    {
        [Fact]
        public void ConstructorTest()
        {
            var config = new KvkApiClientConfig();
            var target = new KvkApiClient(config);
            target.Should().NotBeNull();
        }
        
        [Fact]
        public void ConstructorShouldFailWithNullConfig()
        {
            Assert.Throws<ArgumentNullException>(() => new KvkApiClient(config: null));
        }
    }
}