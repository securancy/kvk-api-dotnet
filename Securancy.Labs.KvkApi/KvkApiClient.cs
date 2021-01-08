using System;

namespace Securancy.Labs.KvkApi
{
    public class KvkApiClient
    {
        private readonly KvkApiClientConfig _config;
        public KvkApiClient(KvkApiClientConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }
    }
}