using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CompanyProfileV2BusinessActivity
    {
        /// <summary>
        /// Gets or Sets SbiCode
        /// </summary>
        [DataMember(Name = "sbiCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sbiCode")]
        public string SbiCode { get; set; }

        /// <summary>
        /// Gets or Sets SbiCodeDescription
        /// </summary>
        [DataMember(Name = "sbiCodeDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sbiCodeDescription")]
        public string SbiCodeDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsMainSbi
        /// </summary>
        [DataMember(Name = "isMainSbi", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isMainSbi")]
        public bool? IsMainSbi { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyProfileV2BusinessActivity {\n");
            sb.Append("  SbiCode: ").Append(SbiCode).Append("\n");
            sb.Append("  SbiCodeDescription: ").Append(SbiCodeDescription).Append("\n");
            sb.Append("  IsMainSbi: ").Append(IsMainSbi).Append("\n");
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