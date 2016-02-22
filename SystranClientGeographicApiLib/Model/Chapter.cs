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
    public class Chapter
    {

        /* Chapter order */
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public string Order { get; set; }


        /* Chapter title */
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }


        /* Chapter introduction */
        [DataMember(Name = "introduction", EmitDefaultValue = false)]
        public string Introduction { get; set; }


        /* Chapter content */
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }



        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Chapter {\n");

            sb.Append("  Order: ").Append(Order).Append("\n");

            sb.Append("  Title: ").Append(Title).Append("\n");

            sb.Append("  Introduction: ").Append(Introduction).Append("\n");

            sb.Append("  Content: ").Append(Content).Append("\n");

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