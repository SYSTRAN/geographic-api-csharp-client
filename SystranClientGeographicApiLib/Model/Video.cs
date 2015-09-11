using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Video
  /// </summary>
  [DataContract]
  public class Video {
    
    /* Label */
    [DataMember(Name="label", EmitDefaultValue=false)]
    public string Label { get; set; }

    
    /* Reference */
    [DataMember(Name="ref", EmitDefaultValue=false)]
    public string Ref { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Video {\n");
      
      sb.Append("  Label: ").Append(Label).Append("\n");
      
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      
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