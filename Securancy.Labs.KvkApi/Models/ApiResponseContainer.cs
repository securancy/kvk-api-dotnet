using System.Collections.Generic;

namespace Securancy.Labs.KvkApi.Models
{
    public class ApiResponseContainer<T>
    {
        public string ApiVersion { get; set; }
        public dynamic Meta { get; set; }
        public ApiResponsePaginatedCollection<T> Data { get; set; }
    }

    public class ApiResponsePaginatedCollection<T>
    {
        public int ItemsPerPage { get; set; }
        public int StartPage { get; set; }
        public int TotalItems { get; set; }
        public string NextLink { get; set; }
        public IReadOnlyCollection<T> Items { get; set; }
    }

}