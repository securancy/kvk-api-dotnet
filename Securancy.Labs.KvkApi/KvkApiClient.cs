using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Securancy.Labs.KvkApi
{
    public class KvkApiClient
    {
        private readonly KvkApiClientConfig _config;
        private readonly HttpClient _http;
        
        public KvkApiClient(KvkApiClientConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            
            // initialize a HttpClient with custom handler, that uses the KvK-specific (root) certificates
            _http = new HttpClient(KvkCertificateBuilder.CreateHttpHandler());
            
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("apikey", _config.ApiKey);
        }

        public async Task SslTest()
        {
            // To check and make sure you have correctly added the new root and intermediate certificates to your system
            // or application you can use http://ssltest.kvk.nl which contains a certificate with the same root and
            // intermediate chain as the new api.kvk.nl certificate.
            const string testEndpoint = "https://ssltest.kvk.nl";
            
            var response = await _http.GetAsync(testEndpoint);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"[{response.StatusCode}] {response.ReasonPhrase}");
        }
    }
}