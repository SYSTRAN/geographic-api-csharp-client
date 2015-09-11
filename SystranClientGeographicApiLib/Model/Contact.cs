using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Contact
  /// </summary>
  [DataContract]
  public class Contact {
    
    /* Array of phone numbers */
    [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
    public List<PhoneNumber> PhoneNumbers { get; set; }

    
    /* Array of mails */
    [DataMember(Name="mails", EmitDefaultValue=false)]
    public List<Mail> Mails { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Contact {\n");
      
      sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
      
      sb.Append("  Mails: ").Append(Mails).Append("\n");
      
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