using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Securancy.Labs.KvkApi;

public abstract class KvkApiBaseClient
{
    private readonly KvkApiClientConfig _config;
    
    protected string BaseUrl => _config.Endpoint;

    protected KvkApiBaseClient(KvkApiClientConfig config)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
        if (string.IsNullOrEmpty(config.ApiKey)) throw new ArgumentNullException(nameof(config));
        if (string.IsNullOrEmpty(config.Endpoint)) throw new ArgumentNullException(nameof(config));
    }

    // Called by implementing swagger client classes
    protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
    {
        var msg = new HttpRequestMessage();
        msg.Headers.Authorization = new AuthenticationHeaderValue("apikey", _config.ApiKey);
        msg.Headers.Add("apikey", _config.ApiKey);
        return Task.FromResult(msg);
    }

}