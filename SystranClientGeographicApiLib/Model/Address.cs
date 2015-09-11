using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Address
  /// </summary>
  [DataContract]
  public class Address {
    
    /* Address components */
    [DataMember(Name="components", EmitDefaultValue=false)]
    public AddressComponents Components { get; set; }

    
    /* Formatted Address (Postal Address) */
    [DataMember(Name="formatted", EmitDefaultValue=false)]
    public string Formatted { get; set; }

    
    /* Vicinity */
    [DataMember(Name="vicinity", EmitDefaultValue=false)]
    public string Vicinity { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Address {\n");
      
      sb.Append("  Components: ").Append(Components).Append("\n");
      
      sb.Append("  Formatted: ").Append(Formatted).Append("\n");
      
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