using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class Resultaat {
  /// <summary>
  /// Geeft aan op welke pagina je bent. Start vanaf pagina 1
  /// </summary>
  /// <value>Geeft aan op welke pagina je bent. Start vanaf pagina 1</value>
  [DataMember(Name="pagina", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "pagina")]
  public int? Pagina { get; set; }

  /// <summary>
  /// Geeft het aantal zoek resultaten per pagina weer
  /// </summary>
  /// <value>Geeft het aantal zoek resultaten per pagina weer</value>
  [DataMember(Name="aantal", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "aantal")]
  public int? Aantal { get; set; }

  /// <summary>
  /// Totaal aantal zoekresultaten gevonden. De API Zoeken toont max. 1000 resultaten.
  /// </summary>
  /// <value>Totaal aantal zoekresultaten gevonden. De API Zoeken toont max. 1000 resultaten.</value>
  [DataMember(Name="totaal", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "totaal")]
  public int? Totaal { get; set; }

  /// <summary>
  /// Link naar de vorige pagina indien beschikbaar
  /// </summary>
  /// <value>Link naar de vorige pagina indien beschikbaar</value>
  [DataMember(Name="vorige", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "vorige")]
  public string Vorige { get; set; }

  /// <summary>
  /// Link naar de volgende pagina indien beschikbaar
  /// </summary>
  /// <value>Link naar de volgende pagina indien beschikbaar</value>
  [DataMember(Name="volgende", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "volgende")]
  public string Volgende { get; set; }

  /// <summary>
  /// Gets or Sets Resultaten
  /// </summary>
  [DataMember(Name="resultaten", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "resultaten")]
  public List<ResultaatItem> Resultaten { get; set; }

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
    sb.Append("class Resultaat {\n");
    sb.Append("  Pagina: ").Append(Pagina).Append("\n");
    sb.Append("  Aantal: ").Append(Aantal).Append("\n");
    sb.Append("  Totaal: ").Append(Totaal).Append("\n");
    sb.Append("  Vorige: ").Append(Vorige).Append("\n");
    sb.Append("  Volgende: ").Append(Volgende).Append("\n");
    sb.Append("  Resultaten: ").Append(Resultaten).Append("\n");
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