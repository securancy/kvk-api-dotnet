using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public class Adres
{
    /// <summary>
    /// Correspondentieadres en/of bezoekadres
    /// </summary>
    /// <value>Correspondentieadres en/of bezoekadres</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Indicatie of het adres is afgeschermd
    /// </summary>
    /// <value>Indicatie of het adres is afgeschermd</value>
    [DataMember(Name = "indAfgeschermd", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "indAfgeschermd")]
    public string IndAfgeschermd { get; set; }

    /// <summary>
    /// Gets or Sets VolledigAdres
    /// </summary>
    [DataMember(Name = "volledigAdres", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "volledigAdres")]
    public string VolledigAdres { get; set; }

    /// <summary>
    /// Gets or Sets Straatnaam
    /// </summary>
    [DataMember(Name = "straatnaam", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "straatnaam")]
    public string Straatnaam { get; set; }

    /// <summary>
    /// Gets or Sets Huisnummer
    /// </summary>
    [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "huisnummer")]
    public int? Huisnummer { get; set; }

    /// <summary>
    /// Gets or Sets HuisnummerToevoeging
    /// </summary>
    [DataMember(Name = "huisnummerToevoeging", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "huisnummerToevoeging")]
    public string HuisnummerToevoeging { get; set; }

    /// <summary>
    /// Gets or Sets Huisletter
    /// </summary>
    [DataMember(Name = "huisletter", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "huisletter")]
    public string Huisletter { get; set; }

    /// <summary>
    /// Gets or Sets AanduidingBijHuisnummer
    /// </summary>
    [DataMember(Name = "aanduidingBijHuisnummer", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "aanduidingBijHuisnummer")]
    public string AanduidingBijHuisnummer { get; set; }

    /// <summary>
    /// Gets or Sets ToevoegingAdres
    /// </summary>
    [DataMember(Name = "toevoegingAdres", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "toevoegingAdres")]
    public string ToevoegingAdres { get; set; }

    /// <summary>
    /// Gets or Sets Postcode
    /// </summary>
    [DataMember(Name = "postcode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "postcode")]
    public string Postcode { get; set; }

    /// <summary>
    /// Gets or Sets Postbusnummer
    /// </summary>
    [DataMember(Name = "postbusnummer", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "postbusnummer")]
    public int? Postbusnummer { get; set; }

    /// <summary>
    /// Gets or Sets Plaats
    /// </summary>
    [DataMember(Name = "plaats", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "plaats")]
    public string Plaats { get; set; }

    /// <summary>
    /// Gets or Sets StraatHuisnummer
    /// </summary>
    [DataMember(Name = "straatHuisnummer", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "straatHuisnummer")]
    public string StraatHuisnummer { get; set; }

    /// <summary>
    /// Gets or Sets PostcodeWoonplaats
    /// </summary>
    [DataMember(Name = "postcodeWoonplaats", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "postcodeWoonplaats")]
    public string PostcodeWoonplaats { get; set; }

    /// <summary>
    /// Gets or Sets Regio
    /// </summary>
    [DataMember(Name = "regio", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "regio")]
    public string Regio { get; set; }

    /// <summary>
    /// Gets or Sets Land
    /// </summary>
    [DataMember(Name = "land", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "land")]
    public string Land { get; set; }

    /// <summary>
    /// Gets or Sets GeoData
    /// </summary>
    [DataMember(Name = "geoData", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "geoData")]
    public GeoData GeoData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Adres {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  IndAfgeschermd: ").Append(IndAfgeschermd).Append("\n");
        sb.Append("  VolledigAdres: ").Append(VolledigAdres).Append("\n");
        sb.Append("  Straatnaam: ").Append(Straatnaam).Append("\n");
        sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
        sb.Append("  HuisnummerToevoeging: ").Append(HuisnummerToevoeging).Append("\n");
        sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
        sb.Append("  AanduidingBijHuisnummer: ").Append(AanduidingBijHuisnummer).Append("\n");
        sb.Append("  ToevoegingAdres: ").Append(ToevoegingAdres).Append("\n");
        sb.Append("  Postcode: ").Append(Postcode).Append("\n");
        sb.Append("  Postbusnummer: ").Append(Postbusnummer).Append("\n");
        sb.Append("  Plaats: ").Append(Plaats).Append("\n");
        sb.Append("  StraatHuisnummer: ").Append(StraatHuisnummer).Append("\n");
        sb.Append("  PostcodeWoonplaats: ").Append(PostcodeWoonplaats).Append("\n");
        sb.Append("  Regio: ").Append(Regio).Append("\n");
        sb.Append("  Land: ").Append(Land).Append("\n");
        sb.Append("  GeoData: ").Append(GeoData).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}