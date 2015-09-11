using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Location
  /// </summary>
  [DataContract]
  public class FullLocation {
    
    /* Position defined by coordinates and type */
    [DataMember(Name="position", EmitDefaultValue=false)]
    public FullPosition Position { get; set; }

    
    /* Address */
    [DataMember(Name="address", EmitDefaultValue=false)]
    public Address Address { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FullLocation {\n");
      
      sb.Append("  Position: ").Append(Position).Append("\n");
      
      sb.Append("  Address: ").Append(Address).Append("\n");
      
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