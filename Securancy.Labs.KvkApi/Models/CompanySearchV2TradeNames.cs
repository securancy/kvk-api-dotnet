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
    public class CompanySearchV2TradeNames
    {
        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name = "businessName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "businessName")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets ShortBusinessName
        /// </summary>
        [DataMember(Name = "shortBusinessName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortBusinessName")]
        public string ShortBusinessName { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTradeNames
        /// </summary>
        [DataMember(Name = "currentTradeNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentTradeNames")]
        public List<string> CurrentTradeNames { get; set; }

        /// <summary>
        /// Gets or Sets FormerTradeNames
        /// </summary>
        [DataMember(Name = "formerTradeNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "formerTradeNames")]
        public List<string> FormerTradeNames { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStatutoryNames
        /// </summary>
        [DataMember(Name = "currentStatutoryNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentStatutoryNames")]
        public List<string> CurrentStatutoryNames { get; set; }

        /// <summary>
        /// Gets or Sets FormerStatutoryNames
        /// </summary>
        [DataMember(Name = "formerStatutoryNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "formerStatutoryNames")]
        public List<string> FormerStatutoryNames { get; set; }

        /// <summary>
        /// Gets or Sets CurrentNames
        /// </summary>
        [DataMember(Name = "currentNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentNames")]
        public List<string> CurrentNames { get; set; }

        /// <summary>
        /// Gets or Sets FormerNames
        /// </summary>
        [DataMember(Name = "formerNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "formerNames")]
        public List<string> FormerNames { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanySearchV2TradeNames {\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  ShortBusinessName: ").Append(ShortBusinessName).Append("\n");
            sb.Append("  CurrentTradeNames: ").Append(CurrentTradeNames).Append("\n");
            sb.Append("  FormerTradeNames: ").Append(FormerTradeNames).Append("\n");
            sb.Append("  CurrentStatutoryNames: ").Append(CurrentStatutoryNames).Append("\n");
            sb.Append("  FormerStatutoryNames: ").Append(FormerStatutoryNames).Append("\n");
            sb.Append("  CurrentNames: ").Append(CurrentNames).Append("\n");
            sb.Append("  FormerNames: ").Append(FormerNames).Append("\n");
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