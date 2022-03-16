using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class Basisprofiel {
  /// <summary>
  /// Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers
  /// </summary>
  /// <value>Nederlands Kamer van Koophandel nummer: bestaat uit 8 cijfers</value>
  [DataMember(Name="kvkNummer", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "kvkNummer")]
  public string KvkNummer { get; set; }

  /// <summary>
  /// Hiermee geeft de onderneming aan geen ongevraagde reclame per post of verkoop aan de deur te willen ontvangen
  /// </summary>
  /// <value>Hiermee geeft de onderneming aan geen ongevraagde reclame per post of verkoop aan de deur te willen ontvangen</value>
  [DataMember(Name="indNonMailing", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indNonMailing")]
  public string IndNonMailing { get; set; }

  /// <summary>
  /// Naam onder Maatschappelijke Activiteit
  /// </summary>
  /// <value>Naam onder Maatschappelijke Activiteit</value>
  [DataMember(Name="naam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "naam")]
  public string Naam { get; set; }

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
  /// Totaal aantal werkzame personen
  /// </summary>
  /// <value>Totaal aantal werkzame personen</value>
  [DataMember(Name="totaalWerkzamePersonen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "totaalWerkzamePersonen")]
  public int? TotaalWerkzamePersonen { get; set; }

  /// <summary>
  /// De naam van de onderneming wanneer er statuten geregistreerd zijn.
  /// </summary>
  /// <value>De naam van de onderneming wanneer er statuten geregistreerd zijn.</value>
  [DataMember(Name="statutaireNaam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "statutaireNaam")]
  public string StatutaireNaam { get; set; }

  /// <summary>
  /// Alle namen waaronder een onderneming of vestiging handelt (op volgorde van registreren)
  /// </summary>
  /// <value>Alle namen waaronder een onderneming of vestiging handelt (op volgorde van registreren)</value>
  [DataMember(Name="handelsnamen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "handelsnamen")]
  public List<Handelsnaam> Handelsnamen { get; set; }

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
  /// Gets or Sets Embedded
  /// </summary>
  [DataMember(Name="_embedded", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "_embedded")]
  public EmbeddedContainer Embedded { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class Basisprofiel {\n");
    sb.Append("  KvkNummer: ").Append(KvkNummer).Append("\n");
    sb.Append("  IndNonMailing: ").Append(IndNonMailing).Append("\n");
    sb.Append("  Naam: ").Append(Naam).Append("\n");
    sb.Append("  FormeleRegistratiedatum: ").Append(FormeleRegistratiedatum).Append("\n");
    sb.Append("  MaterieleRegistratie: ").Append(MaterieleRegistratie).Append("\n");
    sb.Append("  TotaalWerkzamePersonen: ").Append(TotaalWerkzamePersonen).Append("\n");
    sb.Append("  StatutaireNaam: ").Append(StatutaireNaam).Append("\n");
    sb.Append("  Handelsnamen: ").Append(Handelsnamen).Append("\n");
    sb.Append("  SbiActiviteiten: ").Append(SbiActiviteiten).Append("\n");
    sb.Append("  Links: ").Append(Links).Append("\n");
    sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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