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
  public class LiteLocation {
    
    /* Position defined by latitude and longitude */
    [DataMember(Name="position", EmitDefaultValue=false)]
    public Position Position { get; set; }

    
    /* Vicinity description */
    [DataMember(Name="vicinity", EmitDefaultValue=false)]
    public string Vicinity { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiteLocation {\n");
      
      sb.Append("  Position: ").Append(Position).Append("\n");
      
      sb.Append("  Vicinity: ").Append(Vicinity).Append("\n");
      
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