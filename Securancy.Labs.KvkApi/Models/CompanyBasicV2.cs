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
    public class CompanyBasicV2
    {
        /// <summary>
        /// Gets or Sets KvkNumber
        /// </summary>
        [DataMember(Name = "kvkNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kvkNumber")]
        public string KvkNumber { get; set; }

        /// <summary>
        /// Gets or Sets BranchNumber
        /// </summary>
        [DataMember(Name = "branchNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "branchNumber")]
        public string BranchNumber { get; set; }

        /// <summary>
        /// Gets or Sets Rsin
        /// </summary>
        [DataMember(Name = "rsin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rsin")]
        public string Rsin { get; set; }

        /// <summary>
        /// Gets or Sets TradeNames
        /// </summary>
        [DataMember(Name = "tradeNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tradeNames")]
        public CompanySearchV2TradeNames TradeNames { get; set; }

        /// <summary>
        /// Gets or Sets HasEntryInBusinessRegister
        /// </summary>
        [DataMember(Name = "hasEntryInBusinessRegister", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasEntryInBusinessRegister")]
        public bool? HasEntryInBusinessRegister { get; set; }

        /// <summary>
        /// Gets or Sets HasNonMailingIndication
        /// </summary>
        [DataMember(Name = "hasNonMailingIndication", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasNonMailingIndication")]
        public bool? HasNonMailingIndication { get; set; }

        /// <summary>
        /// Gets or Sets IsLegalPerson
        /// </summary>
        [DataMember(Name = "isLegalPerson", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isLegalPerson")]
        public bool? IsLegalPerson { get; set; }

        /// <summary>
        /// Gets or Sets IsBranch
        /// </summary>
        [DataMember(Name = "isBranch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isBranch")]
        public bool? IsBranch { get; set; }

        /// <summary>
        /// Gets or Sets IsMainBranch
        /// </summary>
        [DataMember(Name = "isMainBranch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isMainBranch")]
        public bool? IsMainBranch { get; set; }

        /// <summary>
        /// At most 1 address is returned
        /// </summary>
        /// <value>At most 1 address is returned</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "addresses")]
        public List<CompanySearchV2Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "websites")]
        public List<string> Websites { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyBasicV2 {\n");
            sb.Append("  KvkNumber: ").Append(KvkNumber).Append("\n");
            sb.Append("  BranchNumber: ").Append(BranchNumber).Append("\n");
            sb.Append("  Rsin: ").Append(Rsin).Append("\n");
            sb.Append("  TradeNames: ").Append(TradeNames).Append("\n");
            sb.Append("  HasEntryInBusinessRegister: ").Append(HasEntryInBusinessRegister).Append("\n");
            sb.Append("  HasNonMailingIndication: ").Append(HasNonMailingIndication).Append("\n");
            sb.Append("  IsLegalPerson: ").Append(IsLegalPerson).Append("\n");
            sb.Append("  IsBranch: ").Append(IsBranch).Append("\n");
            sb.Append("  IsMainBranch: ").Append(IsMainBranch).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
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