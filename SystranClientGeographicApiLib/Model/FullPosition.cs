using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Detail position defined by coordinates and type
  /// </summary>
  [DataContract]
  public class FullPosition {
    
    /* Coordinates defined by latitude and longitude */
    [DataMember(Name="coordinates", EmitDefaultValue=false)]
    public List<double?> Coordinates { get; set; }

    
    /* The type of position */
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FullPosition {\n");
      
      sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
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