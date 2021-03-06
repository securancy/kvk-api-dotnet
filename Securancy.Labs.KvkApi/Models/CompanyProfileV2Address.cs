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
    public class CompanyProfileV2Address
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets BagId
        /// </summary>
        [DataMember(Name = "bagId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bagId")]
        public string BagId { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets HouseNumber
        /// </summary>
        [DataMember(Name = "houseNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "houseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or Sets HouseNumberAddition
        /// </summary>
        [DataMember(Name = "houseNumberAddition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "houseNumberAddition")]
        public string HouseNumberAddition { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets GpsLatitude
        /// </summary>
        [DataMember(Name = "gpsLatitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gpsLatitude")]
        public double? GpsLatitude { get; set; }

        /// <summary>
        /// Gets or Sets GpsLongitude
        /// </summary>
        [DataMember(Name = "gpsLongitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gpsLongitude")]
        public double? GpsLongitude { get; set; }

        /// <summary>
        /// Gets or Sets RijksdriehoekX
        /// </summary>
        [DataMember(Name = "rijksdriehoekX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rijksdriehoekX")]
        public double? RijksdriehoekX { get; set; }

        /// <summary>
        /// Gets or Sets RijksdriehoekY
        /// </summary>
        [DataMember(Name = "rijksdriehoekY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rijksdriehoekY")]
        public double? RijksdriehoekY { get; set; }

        /// <summary>
        /// Gets or Sets RijksdriehoekZ
        /// </summary>
        [DataMember(Name = "rijksdriehoekZ", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rijksdriehoekZ")]
        public double? RijksdriehoekZ { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyProfileV2Address {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BagId: ").Append(BagId).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  HouseNumberAddition: ").Append(HouseNumberAddition).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  GpsLatitude: ").Append(GpsLatitude).Append("\n");
            sb.Append("  GpsLongitude: ").Append(GpsLongitude).Append("\n");
            sb.Append("  RijksdriehoekX: ").Append(RijksdriehoekX).Append("\n");
            sb.Append("  RijksdriehoekY: ").Append(RijksdriehoekY).Append("\n");
            sb.Append("  RijksdriehoekZ: ").Append(RijksdriehoekZ).Append("\n");
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