using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class VestigingBasis {
  /// <summary>
  /// Vestigingsnummer: uniek nummer dat bestaat uit 12 cijfers
  /// </summary>
  /// <value>Vestigingsnummer: uniek nummer dat bestaat uit 12 cijfers</value>
  [DataMember(Name="vestigingsnummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "vestigingsnummer")]
  public string Vestigingsnummer { get; set; }

  /// <summary>
  /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers
  /// </summary>
  /// <value>Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers</value>
  [DataMember(Name="kvkNummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "kvkNummer")]
  public string KvkNummer { get; set; }

  /// <summary>
  /// De naam waaronder een onderneming of vestiging handelt
  /// </summary>
  /// <value>De naam waaronder een onderneming of vestiging handelt</value>
  [DataMember(Name="eersteHandelsnaam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "eersteHandelsnaam")]
  public string EersteHandelsnaam { get; set; }

  /// <summary>
  /// Hoofdvestiging (Ja/Nee)
  /// </summary>
  /// <value>Hoofdvestiging (Ja/Nee)</value>
  [DataMember(Name="indHoofdvestiging", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indHoofdvestiging")]
  public string IndHoofdvestiging { get; set; }

  /// <summary>
  /// Indicatie of het adres is afgeschermd
  /// </summary>
  /// <value>Indicatie of het adres is afgeschermd</value>
  [DataMember(Name="indAdresAfgeschermd", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indAdresAfgeschermd")]
  public string IndAdresAfgeschermd { get; set; }

  /// <summary>
  /// Commerciele vestiging  (Ja/Nee)
  /// </summary>
  /// <value>Commerciele vestiging  (Ja/Nee)</value>
  [DataMember(Name="indCommercieleVestiging", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indCommercieleVestiging")]
  public string IndCommercieleVestiging { get; set; }

  /// <summary>
  /// Gets or Sets VolledigAdres
  /// </summary>
  [DataMember(Name="volledigAdres", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "volledigAdres")]
  public string VolledigAdres { get; set; }

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
    sb.Append("class VestigingBasis {\n");
    sb.Append("  Vestigingsnummer: ").Append(Vestigingsnummer).Append("\n");
    sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
    sb.Append("  EersteHandelsnaam: ").Append(EersteHandelsnaam).Append("\n");
    sb.Append("  IndHoofdvestiging: ").Append(IndHoofdvestiging).Append("\n");
    sb.Append("  IndAdresAfgeschermd: ").Append(IndAdresAfgeschermd).Append("\n");
    sb.Append("  IndCommercieleVestiging: ").Append(IndCommercieleVestiging).Append("\n");
    sb.Append("  VolledigAdres: ").Append(VolledigAdres).Append("\n");
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