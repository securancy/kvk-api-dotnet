using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models
{
    /// <summary>
    /// Standardized Resultdata
    /// </summary>
    [DataContract]
    public class ResultDataCompanyBasicV2
    {
        /// <summary>
        /// Amount of search results per page used for the query
        /// </summary>
        /// <value>Amount of search results per page used for the query</value>
        [DataMember(Name = "itemsPerPage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "itemsPerPage")]
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// The current page of the results
        /// </summary>
        /// <value>The current page of the results</value>
        [DataMember(Name = "startPage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startPage")]
        public int? StartPage { get; set; }

        /// <summary>
        /// Total amount of results spread over multiple pages
        /// </summary>
        /// <value>Total amount of results spread over multiple pages</value>
        [DataMember(Name = "totalItems", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalItems")]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Link to next set of ItemsPerPage result items
        /// </summary>
        /// <value>Link to next set of ItemsPerPage result items</value>
        [DataMember(Name = "nextLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Link to previous set of ItemsPerPage result items
        /// </summary>
        /// <value>Link to previous set of ItemsPerPage result items</value>
        [DataMember(Name = "previousLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previousLink")]
        public string PreviousLink { get; set; }

        /// <summary>
        /// Actual search results
        /// </summary>
        /// <value>Actual search results</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<CompanyBasicV2> Items { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultDataCompanyBasicV2 {\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  StartPage: ").Append(StartPage).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
            sb.Append("  PreviousLink: ").Append(PreviousLink).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}