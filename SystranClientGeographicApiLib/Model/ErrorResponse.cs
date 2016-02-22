using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Systran.GeographicClientLib.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ErrorResponse
    {

        /* Readable description of the error */
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }


        /* Additional information about the error */
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public Object Info { get; set; }



        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");

            sb.Append("  Message: ").Append(Message).Append("\n");

            sb.Append("  Info: ").Append(Info).Append("\n");

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