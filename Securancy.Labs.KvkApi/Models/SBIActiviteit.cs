using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// Code beschrijving van SBI activiteiten conform SBI 2008 (Standard Industrial Classification). Er wordt geen maximering toegepast in de resultaten. Zie ook KVK.nl/sbi
/// </summary>
[DataContract]
public class SBIActiviteit {
  /// <summary>
  /// Gets or Sets SbiCode
  /// </summary>
  [DataMember(Name="sbiCode", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "sbiCode")]
  public string SbiCode { get; set; }

  /// <summary>
  /// Gets or Sets SbiOmschrijving
  /// </summary>
  [DataMember(Name="sbiOmschrijving", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "sbiOmschrijving")]
  public string SbiOmschrijving { get; set; }

  /// <summary>
  /// Gets or Sets IndHoofdactiviteit
  /// </summary>
  [DataMember(Name="indHoofdactiviteit", EmitDefaultValue=false)]
  [JsonProperty(PropertyName = "indHoofdactiviteit")]
  public string IndHoofdactiviteit { get; set; }


  /// <summary>
  /// Get the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()  {
    var sb = new StringBuilder();
    sb.Append("class SBIActiviteit {\n");
    sb.Append("  SbiCode: ").Append(SbiCode).Append("\n");
    sb.Append("  SbiOmschrijving: ").Append(SbiOmschrijving).Append("\n");
    sb.Append("  IndHoofdactiviteit: ").Append(IndHoofdactiviteit).Append("\n");
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