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
    public class CompanyExtendedV2
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
        public CompanyProfileV2TradeNames TradeNames { get; set; }

        /// <summary>
        /// Gets or Sets LegalForm
        /// </summary>
        [DataMember(Name = "legalForm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "legalForm")]
        public string LegalForm { get; set; }

        /// <summary>
        /// Gets or Sets BusinessActivities
        /// </summary>
        [DataMember(Name = "businessActivities", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "businessActivities")]
        public List<CompanyProfileV2BusinessActivity> BusinessActivities { get; set; }

        /// <summary>
        /// Gets or Sets HasEntryInBusinessRegister
        /// </summary>
        [DataMember(Name = "hasEntryInBusinessRegister", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasEntryInBusinessRegister")]
        public bool? HasEntryInBusinessRegister { get; set; }

        /// <summary>
        /// Gets or Sets HasCommercialActivities
        /// </summary>
        [DataMember(Name = "hasCommercialActivities", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasCommercialActivities")]
        public bool? HasCommercialActivities { get; set; }

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
        /// Gets or Sets Employees
        /// </summary>
        [DataMember(Name = "employees", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "employees")]
        public int? Employees { get; set; }

        /// <summary>
        /// Gets or Sets FoundationDate
        /// </summary>
        [DataMember(Name = "foundationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "foundationDate")]
        public string FoundationDate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name = "registrationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "registrationDate")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets DeregistrationDate
        /// </summary>
        [DataMember(Name = "deregistrationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deregistrationDate")]
        public string DeregistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "addresses")]
        public List<CompanyProfileV2Address> Addresses { get; set; }

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
            sb.Append("class CompanyExtendedV2 {\n");
            sb.Append("  KvkNumber: ").Append(KvkNumber).Append("\n");
            sb.Append("  BranchNumber: ").Append(BranchNumber).Append("\n");
            sb.Append("  Rsin: ").Append(Rsin).Append("\n");
            sb.Append("  TradeNames: ").Append(TradeNames).Append("\n");
            sb.Append("  LegalForm: ").Append(LegalForm).Append("\n");
            sb.Append("  BusinessActivities: ").Append(BusinessActivities).Append("\n");
            sb.Append("  HasEntryInBusinessRegister: ").Append(HasEntryInBusinessRegister).Append("\n");
            sb.Append("  HasCommercialActivities: ").Append(HasCommercialActivities).Append("\n");
            sb.Append("  HasNonMailingIndication: ").Append(HasNonMailingIndication).Append("\n");
            sb.Append("  IsLegalPerson: ").Append(IsLegalPerson).Append("\n");
            sb.Append("  IsBranch: ").Append(IsBranch).Append("\n");
            sb.Append("  IsMainBranch: ").Append(IsMainBranch).Append("\n");
            sb.Append("  Employees: ").Append(Employees).Append("\n");
            sb.Append("  FoundationDate: ").Append(FoundationDate).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  DeregistrationDate: ").Append(DeregistrationDate).Append("\n");
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