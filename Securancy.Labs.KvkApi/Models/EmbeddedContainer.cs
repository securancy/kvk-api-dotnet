using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class EmbeddedContainer {
  /// <summary>
  /// Gets or Sets Hoofdvestiging
  /// </summary>
  [DataMember(Name="hoofdvestiging", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "hoofdvestiging")]
  public Vestiging Hoofdvestiging { get; set; }

  /// <summary>
  /// Gets or Sets Eigenaar
  /// </summary>
  [DataMember(Name="eigenaar", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "eigenaar")]
  public Eigenaar Eigenaar { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class EmbeddedContainer {\n");
    sb.Append("  Hoofdvestiging: ").Append(Hoofdvestiging).Append("\n");
    sb.Append("  Eigenaar: ").Append(Eigenaar).Append("\n");
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