using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Phone number
  /// </summary>
  [DataContract]
  public class PhoneNumber {
    
    /* Raw phone number */
    [DataMember(Name="value", EmitDefaultValue=false)]
    public string Value { get; set; }

    
    /* Formatted phone number */
    [DataMember(Name="formatted", EmitDefaultValue=false)]
    public string Formatted { get; set; }

    
    /* International phone number */
    [DataMember(Name="international", EmitDefaultValue=false)]
    public string International { get; set; }

    
    /* Professional, Fax, Mobile, ... */
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneNumber {\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Formatted: ").Append(Formatted).Append("\n");
      
      sb.Append("  International: ").Append(International).Append("\n");
      
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