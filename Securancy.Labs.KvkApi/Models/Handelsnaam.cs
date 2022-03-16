using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// Alle namen waaronder een onderneming of vestiging handelt (op volgorde van registreren)
/// </summary>
[DataContract]
public class Handelsnaam {
  /// <summary>
  /// Gets or Sets Naam
  /// </summary>
  [DataMember(Name="naam", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "naam")]
  public string Naam { get; set; }

  /// <summary>
  /// Gets or Sets Volgorde
  /// </summary>
  [DataMember(Name="volgorde", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "volgorde")]
  public int? Volgorde { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class Handelsnaam {\n");
    sb.Append("  Naam: ").Append(Naam).Append("\n");
    sb.Append("  Volgorde: ").Append(Volgorde).Append("\n");
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