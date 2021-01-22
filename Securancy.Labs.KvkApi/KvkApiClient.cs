using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hanssens.Net.Http;
using Newtonsoft.Json;
using Securancy.Labs.KvkApi.Models;

namespace Securancy.Labs.KvkApi
{
    public class KvkApiClient
    {
        private readonly KvkApiClientConfig _config;
        private readonly HttpFactory _http;
        private readonly Dictionary<string, string> _headers;
        
        public KvkApiClient(KvkApiClientConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            if (string.IsNullOrEmpty(config.ApiKey)) throw new ArgumentNullException(nameof(config.ApiKey));
            if (string.IsNullOrEmpty(config.Endpoint)) throw new ArgumentNullException(nameof(config.Endpoint));
            
            // initialize a HttpClient with custom handler, that uses the KvK-specific (root) certificates
            var httpClient = new HttpClient(KvkCertificateBuilder.CreateHttpHandler());

            // initialize the headers
            _headers = new Dictionary<string, string> {{"apikey", config.ApiKey}};

            _http = new HttpFactory(httpClient);
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

        public async Task<ApiResponseContainer<CompanyBasicV2>> SearchCompanies(SearchCompaniesParameters parameters)
        {
            var endpoint = $"{_config.Endpoint}/search/companies";
            
            // null checks
            var queryParams = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(parameters.Context)) queryParams.Add("context", parameters.Context);
            if (!string.IsNullOrEmpty(parameters.Query)) queryParams.Add("q", parameters.Query);
            if (!string.IsNullOrEmpty(parameters.Rsin)) queryParams.Add("rsin", parameters.Rsin);
            if (!string.IsNullOrEmpty(parameters.Site)) queryParams.Add("context", parameters.Site);
            if (!string.IsNullOrEmpty(parameters.BranchNumber)) queryParams.Add("branchnumber", parameters.BranchNumber);
            if (!string.IsNullOrEmpty(parameters.KvkNumber)) queryParams.Add("kvknumber", parameters.KvkNumber);
            if (parameters.IncludeInactiveRegistrations.HasValue) queryParams.Add("includeInactiveRegistrations", parameters.IncludeInactiveRegistrations.ToString().ToLower());
            if (parameters.RestrictToMainBranch.HasValue) queryParams.Add("restrictToMainBranch", parameters.RestrictToMainBranch.ToString().ToLower());
            
            // validation
            if (string.IsNullOrEmpty(parameters.Query)) throw new Exception("Parameter 'q' is required");
            
            return await _Execute<ApiResponseContainer<CompanyBasicV2>>(endpoint, parameters: queryParams);
        }

        public async Task<CompanyBasicV2> TestSearchCompanies()
        {
            var endpoint = "https://api.kvk.nl/api/v2/testsearch/companies?q=test";
            return await _Execute<CompanyBasicV2>(endpoint);
        }

        public async Task<ApiResponseContainer<CompanyExtendedV2>> SearchProfiles(SearchProfileParameters parameters)
        {
            var endpoint = $"{_config.Endpoint}/profile/companies";
            
            // null checks
            var queryParams = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(parameters.Context)) queryParams.Add("context", parameters.Context);
            if (!string.IsNullOrEmpty(parameters.Query)) queryParams.Add("q", parameters.Query);
            if (!string.IsNullOrEmpty(parameters.Rsin)) queryParams.Add("rsin", parameters.Rsin);
            if (!string.IsNullOrEmpty(parameters.BranchNumber)) queryParams.Add("branchnumber", parameters.BranchNumber);
            if (!string.IsNullOrEmpty(parameters.KvkNumber)) queryParams.Add("kvknumber", parameters.KvkNumber);
            if (parameters.IncludeInactiveRegistrations.HasValue) queryParams.Add("includeInactiveRegistrations", parameters.IncludeInactiveRegistrations.ToString().ToLower());
            if (parameters.RestrictToMainBranch.HasValue) queryParams.Add("restrictToMainBranch", parameters.RestrictToMainBranch.ToString().ToLower());
            
            return await _Execute<ApiResponseContainer<CompanyExtendedV2>>(endpoint, parameters: queryParams);
        }
        
        public async Task<CompanyBasicV2> TestSearchProfiles()
        {
            var endpoint = "https://api.kvk.nl/api/v2/testprofile/companies?q=test";
            return await _Execute<CompanyBasicV2>(endpoint);
        }

        private async Task<T> _Execute<T>(string endpoint, Dictionary<string, string> parameters = null)
        {
            if (parameters != null && parameters.Any())
            {
                endpoint += "?";
                endpoint += string.Join("&", parameters.Select(kvp => $"{kvp.Key}={kvp.Value}"));
            }

            var response = await _http.GetAsync(endpoint, headers: _headers);
            response.EnsureSuccessStatusCode();

            // extract raw data and convert it to json
            var data = await response.Content.ReadAsStringAsync();            
            var deserialized = JsonConvert.DeserializeObject<T>(data);
            return deserialized;
        }

    }
}