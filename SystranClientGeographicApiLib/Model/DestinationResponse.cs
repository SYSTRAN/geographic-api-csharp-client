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
    public class DestinationResponse
    {

        /* Error at request level */
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public ErrorResponse Error { get; set; }


        /* Total number of elements matching the criteria (for pagination) */
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int? Total { get; set; }


        /* Pagination offset */
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int? Offset { get; set; }


        /* Array of destinations */
        [DataMember(Name = "destinations", EmitDefaultValue = false)]
        public List<Destination> Destinations { get; set; }



        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinationResponse {\n");

            sb.Append("  Error: ").Append(Error).Append("\n");

            sb.Append("  Total: ").Append(Total).Append("\n");

            sb.Append("  Offset: ").Append(Offset).Append("\n");

            sb.Append("  Destinations: ").Append(Destinations).Append("\n");

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