using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Opening hours
  /// </summary>
  [DataContract]
  public class OpeningHours {
    
    /* Opening hour (day(1 digit),hour(2 digits), minutes(2digits)), ex: 50928 for Friday 9h28 */
    [DataMember(Name="begin", EmitDefaultValue=false)]
    public int? Begin { get; set; }

    
    /* Closing hour (day(1 digit),hour(2 digits), minutes(2digits)), ex: 51722 for Friday 17h22 */
    [DataMember(Name="end", EmitDefaultValue=false)]
    public int? End { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OpeningHours {\n");
      
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