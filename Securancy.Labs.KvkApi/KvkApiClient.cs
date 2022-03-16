using System.Net;
using Hanssens.Net.Http;
using Newtonsoft.Json;
using Securancy.Labs.KvkApi.Models;

namespace Securancy.Labs.KvkApi;

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

        // initialize a HttpClient
        var httpClient = new HttpClient();

        // initialize the headers
        _headers = new Dictionary<string, string>
        {
            {
                "apikey", config.ApiKey
            }
        };

        _http = new HttpFactory(httpClient);
    }

    public async Task<Resultaat?> SearchCompanies(SearchCompaniesParameters parameters)
    {
        var endpoint = $"{_config.Endpoint}/zoeken";

        // null checks
        var queryParams = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(parameters.TradeName)) queryParams.Add("handelsnaam", parameters.TradeName);
        if (!string.IsNullOrEmpty(parameters.KvkNumber) && parameters.KvkNumber != "0" && parameters.KvkNumber.Length == 8) queryParams.Add("kvknummer", parameters.KvkNumber);
        if (!string.IsNullOrEmpty(parameters.SearchType)) queryParams.Add("type", parameters.SearchType);
        if (parameters.Page != null) queryParams.Add("pagina", parameters.Page.ToString());
        if (parameters.Take != null) queryParams.Add("aantal", parameters.Take.ToString());

        return await _Execute<Resultaat>(endpoint, parameters: queryParams);
    }

    public async Task<Basisprofiel?> SearchBasicProfile(string kvkNumber, bool geoData = false)
    {
        var endpoint = $"{_config.Endpoint}/basisprofielen/{kvkNumber}";

        // null checks
        var queryParams = new Dictionary<string, string>();
        queryParams.Add("geoData", geoData.ToString());

        return await _Execute<Basisprofiel>(endpoint, parameters: queryParams);
    }

    private async Task<T?> _Execute<T>(string endpoint, Dictionary<string, string>? parameters = null)
    {
        if (parameters != null && parameters.Any())
        {
            endpoint += "?";
            endpoint += string.Join("&", parameters.Select(kvp => $"{kvp.Key}={kvp.Value}"));
        }

        var response = await _http.GetAsync(endpoint, headers: _headers);
        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            return default;
        }
        response.EnsureSuccessStatusCode();

        // extract raw data and convert it to json
        var data = await response.Content.ReadAsStringAsync();
        var deserialized = JsonConvert.DeserializeObject<T>(data);
        return deserialized;
    }

}