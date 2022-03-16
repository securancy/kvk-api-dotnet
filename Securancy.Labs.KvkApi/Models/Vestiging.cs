using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class Vestiging {
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
  /// Rechtspersonen Samenwerkingsverbanden Informatie Nummer
  /// </summary>
  /// <value>Rechtspersonen Samenwerkingsverbanden Informatie Nummer</value>
  [DataMember(Name="rsin", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rsin")]
  public string Rsin { get; set; }

  /// <summary>
  /// Hiermee geeft de onderneming aan geen ongevraagde reclame per post of verkoop aan de deur te willen ontvangen
  /// </summary>
  /// <value>Hiermee geeft de onderneming aan geen ongevraagde reclame per post of verkoop aan de deur te willen ontvangen</value>
  [DataMember(Name="indNonMailing", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indNonMailing")]
  public string IndNonMailing { get; set; }

  /// <summary>
  /// Registratiedatum onderneming in HR
  /// </summary>
  /// <value>Registratiedatum onderneming in HR</value>
  [DataMember(Name="formeleRegistratiedatum", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "formeleRegistratiedatum")]
  public string FormeleRegistratiedatum { get; set; }

  /// <summary>
  /// Gets or Sets MaterieleRegistratie
  /// </summary>
  [DataMember(Name="materieleRegistratie", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "materieleRegistratie")]
  public MaterieleRegistratie MaterieleRegistratie { get; set; }

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
  /// Commerciele vestiging  (Ja/Nee)
  /// </summary>
  /// <value>Commerciele vestiging  (Ja/Nee)</value>
  [DataMember(Name="indCommercieleVestiging", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indCommercieleVestiging")]
  public string IndCommercieleVestiging { get; set; }

  /// <summary>
  /// Aantal voltijd werkzame personen
  /// </summary>
  /// <value>Aantal voltijd werkzame personen</value>
  [DataMember(Name="voltijdWerkzamePersonen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "voltijdWerkzamePersonen")]
  public int? VoltijdWerkzamePersonen { get; set; }

  /// <summary>
  /// Totaal aantal werkzame personen
  /// </summary>
  /// <value>Totaal aantal werkzame personen</value>
  [DataMember(Name="totaalWerkzamePersonen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "totaalWerkzamePersonen")]
  public int? TotaalWerkzamePersonen { get; set; }

  /// <summary>
  /// Aantal deeltijd werkzame personen
  /// </summary>
  /// <value>Aantal deeltijd werkzame personen</value>
  [DataMember(Name="deeltijdWerkzamePersonen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "deeltijdWerkzamePersonen")]
  public int? DeeltijdWerkzamePersonen { get; set; }

  /// <summary>
  /// Gets or Sets Adressen
  /// </summary>
  [DataMember(Name="adressen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "adressen")]
  public List<Adres> Adressen { get; set; }

  /// <summary>
  /// Gets or Sets Websites
  /// </summary>
  [DataMember(Name="websites", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "websites")]
  public List<string> Websites { get; set; }

  /// <summary>
  /// Code beschrijving van SBI activiteiten conform SBI 2008 (Standard Industrial Classification). Er wordt geen maximering toegepast in de resultaten. Zie ook KVK.nl/sbi
  /// </summary>
  /// <value>Code beschrijving van SBI activiteiten conform SBI 2008 (Standard Industrial Classification). Er wordt geen maximering toegepast in de resultaten. Zie ook KVK.nl/sbi</value>
  [DataMember(Name="sbiActiviteiten", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "sbiActiviteiten")]
  public List<SBIActiviteit> SbiActiviteiten { get; set; }

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
    sb.Append("class Vestiging {\n");
    sb.Append("  Vestigingsnummer: ").Append(Vestigingsnummer).Append("\n");
    sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
    sb.Append("  Rsin: ").Append(Rsin).Append("\n");
    sb.Append("  IndNonMailing: ").Append(IndNonMailing).Append("\n");
    sb.Append("  FormeleRegistratiedatum: ").Append(FormeleRegistratiedatum).Append("\n");
    sb.Append("  MaterieleRegistratie: ").Append(MaterieleRegistratie).Append("\n");
    sb.Append("  EersteHandelsnaam: ").Append(EersteHandelsnaam).Append("\n");
    sb.Append("  IndHoofdvestiging: ").Append(IndHoofdvestiging).Append("\n");
    sb.Append("  IndCommercieleVestiging: ").Append(IndCommercieleVestiging).Append("\n");
    sb.Append("  VoltijdWerkzamePersonen: ").Append(VoltijdWerkzamePersonen).Append("\n");
    sb.Append("  TotaalWerkzamePersonen: ").Append(TotaalWerkzamePersonen).Append("\n");
    sb.Append("  DeeltijdWerkzamePersonen: ").Append(DeeltijdWerkzamePersonen).Append("\n");
    sb.Append("  Adressen: ").Append(Adressen).Append("\n");
    sb.Append("  Websites: ").Append(Websites).Append("\n");
    sb.Append("  SbiActiviteiten: ").Append(SbiActiviteiten).Append("\n");
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