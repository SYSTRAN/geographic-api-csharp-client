using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PoiResponse {
    
    /* Total number of elements matching the criteria (for pagination) */
    [DataMember(Name="total", EmitDefaultValue=false)]
    public int? Total { get; set; }

    
    /* Pagination offset */
    [DataMember(Name="offset", EmitDefaultValue=false)]
    public int? Offset { get; set; }

    
    /* Array of lite POI */
    [DataMember(Name="pointsOfInterest", EmitDefaultValue=false)]
    public List<LitePOI> PointsOfInterest { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PoiResponse {\n");
      
      sb.Append("  Total: ").Append(Total).Append("\n");
      
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      
      sb.Append("  PointsOfInterest: ").Append(PointsOfInterest).Append("\n");
      
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