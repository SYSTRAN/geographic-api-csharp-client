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
  public class Review {
    
    /* Text */
    [DataMember(Name="text", EmitDefaultValue=false)]
    public string Text { get; set; }

    
    /* Language */
    [DataMember(Name="language", EmitDefaultValue=false)]
    public string Language { get; set; }

    
    /* Author */
    [DataMember(Name="author", EmitDefaultValue=false)]
    public string Author { get; set; }

    
    /* Rating */
    [DataMember(Name="rating", EmitDefaultValue=false)]
    public int? Rating { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Review {\n");
      
      sb.Append("  Text: ").Append(Text).Append("\n");
      
      sb.Append("  Language: ").Append(Language).Append("\n");
      
      sb.Append("  Author: ").Append(Author).Append("\n");
      
      sb.Append("  Rating: ").Append(Rating).Append("\n");
      
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