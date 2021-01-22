using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Securancy.Labs.KvkApi.Tests
{
    public abstract class BaseTests
    {
        protected KvkApiClientConfig _config = new KvkApiClientConfig()
        {
            Endpoint = "",
            ApiKey = ""
        };
    }
}