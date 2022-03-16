using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class Eigenaar {
  /// <summary>
  /// Rechtspersonen Samenwerkingsverbanden Informatie Nummer
  /// </summary>
  /// <value>Rechtspersonen Samenwerkingsverbanden Informatie Nummer</value>
  [DataMember(Name="rsin", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rsin")]
  public string Rsin { get; set; }

  /// <summary>
  /// Gets or Sets Rechtsvorm
  /// </summary>
  [DataMember(Name="rechtsvorm", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "rechtsvorm")]
  public string Rechtsvorm { get; set; }

  /// <summary>
  /// Gets or Sets UitgebreideRechtsvorm
  /// </summary>
  [DataMember(Name="uitgebreideRechtsvorm", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "uitgebreideRechtsvorm")]
  public string UitgebreideRechtsvorm { get; set; }

  /// <summary>
  /// Gets or Sets Adressen
  /// </summary>
  [DataMember(Name="adressen", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "adressen")]
  public List<Adres> Adressen { get; set; }

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
    sb.Append("class Eigenaar {\n");
    sb.Append("  Rsin: ").Append(Rsin).Append("\n");
    sb.Append("  Rechtsvorm: ").Append(Rechtsvorm).Append("\n");
    sb.Append("  UitgebreideRechtsvorm: ").Append(UitgebreideRechtsvorm).Append("\n");
    sb.Append("  Adressen: ").Append(Adressen).Append("\n");
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