using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class MaterieleRegistratie {
  /// <summary>
  /// Startdatum onderneming
  /// </summary>
  /// <value>Startdatum onderneming</value>
  [DataMember(Name="datumAanvang", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "datumAanvang")]
  public string DatumAanvang { get; set; }

  /// <summary>
  /// Einddatum onderneming
  /// </summary>
  /// <value>Einddatum onderneming</value>
  [DataMember(Name="datumEinde", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "datumEinde")]
  public string DatumEinde { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class MaterieleRegistratie {\n");
    sb.Append("  DatumAanvang: ").Append(DatumAanvang).Append("\n");
    sb.Append("  DatumEinde: ").Append(DatumEinde).Append("\n");
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