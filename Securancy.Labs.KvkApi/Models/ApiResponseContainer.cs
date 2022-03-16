namespace Securancy.Labs.KvkApi.Models;

public class ApiResponseContainer<T>
{
    public string ApiVersion { get; set; }
    public dynamic Meta { get; set; }
    public ApiResponsePaginatedCollection<T> Data { get; set; }
}

public class ApiResponsePaginatedCollection<T>
{
    public int Pagina { get; set; }
    public int Aantal { get; set; }
    public int Totaal { get; set; }
    public string Volgende { get; set; }
    public IReadOnlyCollection<T> Resultaten { get; set; }
}