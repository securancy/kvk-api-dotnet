using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// Basisregistratie Adressen en Gebouwen gegevens uit het kadaster
/// </summary>
[DataContract]
public class GeoData {
  /// <summary>
  /// Unieke BAG id
  /// </summary>
  /// <value>Unieke BAG id</value>
  [DataMember(Name="addresseerbaarObjectId", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "addresseerbaarObjectId")]
  public string AddresseerbaarObjectId { get; set; }

  /// <summary>
  /// Unieke BAG nummeraanduiding id
  /// </summary>
  /// <value>Unieke BAG nummeraanduiding id</value>
  [DataMember(Name="nummerAanduidingId", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "nummerAanduidingId")]
  public string NummerAanduidingId { get; set; }

  /// <summary>
  /// Lengtegraad
  /// </summary>
  /// <value>Lengtegraad</value>
  [DataMember(Name="gpsLatitude", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "gpsLatitude")]
  public double? GpsLatitude { get; set; }

  /// <summary>
  /// Breedtegraad
  /// </summary>
  /// <value>Breedtegraad</value>
  [DataMember(Name="gpsLongitude", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "gpsLongitude")]
  public double? GpsLongitude { get; set; }

  /// <summary>
  /// Rijksdriehoek X-coördinaat
  /// </summary>
  /// <value>Rijksdriehoek X-coördinaat</value>
  [DataMember(Name="rijksdriehoekX", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rijksdriehoekX")]
  public double? RijksdriehoekX { get; set; }

  /// <summary>
  /// Rijksdriehoek Y-coördinaat
  /// </summary>
  /// <value>Rijksdriehoek Y-coördinaat</value>
  [DataMember(Name="rijksdriehoekY", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rijksdriehoekY")]
  public double? RijksdriehoekY { get; set; }

  /// <summary>
  /// Rijksdriehoek Z-coördinaat
  /// </summary>
  /// <value>Rijksdriehoek Z-coördinaat</value>
  [DataMember(Name="rijksdriehoekZ", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rijksdriehoekZ")]
  public double? RijksdriehoekZ { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class GeoData {\n");
    sb.Append("  AddresseerbaarObjectId: ").Append(AddresseerbaarObjectId).Append("\n");
    sb.Append("  NummerAanduidingId: ").Append(NummerAanduidingId).Append("\n");
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
  public string ToJson() {
    return JsonConvert.SerializeObject(this, Formatting.Indented);
  }

}