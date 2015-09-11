using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Event with only basic information
  /// </summary>
  [DataContract]
  public class LiteEvent {
    
    /* Event Identifier */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Location */
    [DataMember(Name="location", EmitDefaultValue=false)]
    public LiteLocation Location { get; set; }

    
    /* Name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Opening dates */
    [DataMember(Name="openingDates", EmitDefaultValue=false)]
    public OpeningDates OpeningDates { get; set; }

    
    /* Main type */
    [DataMember(Name="mainType", EmitDefaultValue=false)]
    public string MainType { get; set; }

    
    /* Types, ordered from general to specific */
    [DataMember(Name="types", EmitDefaultValue=false)]
    public List<string> Types { get; set; }

    
    /* Rating */
    [DataMember(Name="rating", EmitDefaultValue=false)]
    public int? Rating { get; set; }

    
    /* Price Level */
    [DataMember(Name="priceLevel", EmitDefaultValue=false)]
    public int? PriceLevel { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiteEvent {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Location: ").Append(Location).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  OpeningDates: ").Append(OpeningDates).Append("\n");
      
      sb.Append("  MainType: ").Append(MainType).Append("\n");
      
      sb.Append("  Types: ").Append(Types).Append("\n");
      
      sb.Append("  Rating: ").Append(Rating).Append("\n");
      
      sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
      
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
  
  
}