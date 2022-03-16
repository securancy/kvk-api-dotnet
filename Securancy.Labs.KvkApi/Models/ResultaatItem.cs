using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class ResultaatItem {
  /// <summary>
  /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers
  /// </summary>
  /// <value>Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers</value>
  [DataMember(Name="kvkNummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "kvkNummer")]
  public string KvkNummer { get; set; }

  /// <summary>
  /// Rechtspersonen Samenwerkingsverbanden Informatie Nummer
  /// </summary>
  /// <value>Rechtspersonen Samenwerkingsverbanden Informatie Nummer</value>
  [DataMember(Name="rsin", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rsin")]
  public string Rsin { get; set; }

  /// <summary>
  /// Vestigingsnummer: uniek nummer dat bestaat uit 12 cijfers
  /// </summary>
  /// <value>Vestigingsnummer: uniek nummer dat bestaat uit 12 cijfers</value>
  [DataMember(Name="vestigingsnummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "vestigingsnummer")]
  public string Vestigingsnummer { get; set; }

  /// <summary>
  /// De naam waaronder een vestiging of rechtspersoon handelt
  /// </summary>
  /// <value>De naam waaronder een vestiging of rechtspersoon handelt</value>
  [DataMember(Name="handelsnaam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "handelsnaam")]
  public string Handelsnaam { get; set; }

  /// <summary>
  /// Gets or Sets Straatnaam
  /// </summary>
  [DataMember(Name="straatnaam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "straatnaam")]
  public string Straatnaam { get; set; }

  /// <summary>
  /// Gets or Sets Huisnummer
  /// </summary>
  [DataMember(Name="huisnummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "huisnummer")]
  public int? Huisnummer { get; set; }

  /// <summary>
  /// Gets or Sets HuisnummerToevoeging
  /// </summary>
  [DataMember(Name="huisnummerToevoeging", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "huisnummerToevoeging")]
  public string HuisnummerToevoeging { get; set; }

  /// <summary>
  /// Gets or Sets Postcode
  /// </summary>
  [DataMember(Name="postcode", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "postcode")]
  public string Postcode { get; set; }

  /// <summary>
  /// Gets or Sets Plaats
  /// </summary>
  [DataMember(Name="plaats", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "plaats")]
  public string Plaats { get; set; }

  /// <summary>
  /// hoofdvestiging/nevenvestiging/rechtspersoon
  /// </summary>
  /// <value>hoofdvestiging/nevenvestiging/rechtspersoon</value>
  [DataMember(Name="type", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "type")]
  public string Type { get; set; }

  /// <summary>
  /// Indicatie of inschrijving actief is
  /// </summary>
  /// <value>Indicatie of inschrijving actief is</value>
  [DataMember(Name="actief", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "actief")]
  public string Actief { get; set; }

  /// <summary>
  /// Bevat de vervallen handelsnaam of statutaire naam waar dit zoekresultaat mee gevonden is.
  /// </summary>
  /// <value>Bevat de vervallen handelsnaam of statutaire naam waar dit zoekresultaat mee gevonden is.</value>
  [DataMember(Name="vervallenNaam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "vervallenNaam")]
  public string VervallenNaam { get; set; }

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
    sb.Append("class ResultaatItem {\n");
    sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
    sb.Append("  Rsin: ").Append(Rsin).Append("\n");
    sb.Append("  Vestigingsnummer: ").Append(Vestigingsnummer).Append("\n");
    sb.Append("  Handelsnaam: ").Append(Handelsnaam).Append("\n");
    sb.Append("  Straatnaam: ").Append(Straatnaam).Append("\n");
    sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
    sb.Append("  HuisnummerToevoeging: ").Append(HuisnummerToevoeging).Append("\n");
    sb.Append("  Postcode: ").Append(Postcode).Append("\n");
    sb.Append("  Plaats: ").Append(Plaats).Append("\n");
    sb.Append("  Type: ").Append(Type).Append("\n");
    sb.Append("  Actief: ").Append(Actief).Append("\n");
    sb.Append("  VervallenNaam: ").Append(VervallenNaam).Append("\n");
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