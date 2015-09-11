using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Opening dates
  /// </summary>
  [DataContract]
  public class OpeningDates {
    
    /* Begin date */
    [DataMember(Name="begin", EmitDefaultValue=false)]
    public string Begin { get; set; }

    
    /* End date */
    [DataMember(Name="end", EmitDefaultValue=false)]
    public string End { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OpeningDates {\n");
      
      sb.Append("  Begin: ").Append(Begin).Append("\n");
      
      sb.Append("  End: ").Append(End).Append("\n");
      
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