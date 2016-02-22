using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Systran.GeographicClientLib.Model { 

  /// <summary>
  /// 
  /// </summary>
[DataContract]
public class InspirationDetailsResponse
{

    /* Error at request level */
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public ErrorResponse Error { get; set; }


    /* Full Inspiration data */
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public FullInspiration Result { get; set; }



    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InspirationDetailsResponse {\n");

        sb.Append("  Error: ").Append(Error).Append("\n");

        sb.Append("  Result: ").Append(Result).Append("\n");

        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}


}
