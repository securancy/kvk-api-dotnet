using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class VestigingList {
  /// <summary>
  /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers
  /// </summary>
  /// <value>Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers</value>
  [DataMember(Name="kvkNummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "kvkNummer")]
  public string KvkNummer { get; set; }

  /// <summary>
  /// Gets or Sets AantalCommercieleVestigingen
  /// </summary>
  [DataMember(Name="aantalCommercieleVestigingen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "aantalCommercieleVestigingen")]
  public long? AantalCommercieleVestigingen { get; set; }

  /// <summary>
  /// Gets or Sets AantalNietCommercieleVestigingen
  /// </summary>
  [DataMember(Name="aantalNietCommercieleVestigingen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "aantalNietCommercieleVestigingen")]
  public long? AantalNietCommercieleVestigingen { get; set; }

  /// <summary>
  /// Gets or Sets TotaalAantalVestigingen
  /// </summary>
  [DataMember(Name="totaalAantalVestigingen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "totaalAantalVestigingen")]
  public long? TotaalAantalVestigingen { get; set; }

  /// <summary>
  /// Gets or Sets Vestigingen
  /// </summary>
  [DataMember(Name="vestigingen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "vestigingen")]
  public List<VestigingBasis> Vestigingen { get; set; }

  /// <summary>
  /// Gets or Sets Links
  /// </summary>
  [DataMember(Name="links", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "links")]
  public List<Link> Links { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class VestigingList {\n");
    sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
    sb.Append("  AantalCommercieleVestigingen: ").Append(AantalCommercieleVestigingen).Append("\n");
    sb.Append("  AantalNietCommercieleVestigingen: ").Append(AantalNietCommercieleVestigingen).Append("\n");
    sb.Append("  TotaalAantalVestigingen: ").Append(TotaalAantalVestigingen).Append("\n");
    sb.Append("  Vestigingen: ").Append(Vestigingen).Append("\n");
    sb.Append("  Links: ").Append(Links).Append("\n");
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