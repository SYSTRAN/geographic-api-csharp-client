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
    /// Destination with detailled information
    /// </summary>
    [DataContract]
    public class FullDestination
    {

        /* Destination identifier */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }


        /* Location */
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public FullLocation Location { get; set; }


        /* Title */
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }


        /* Headline */
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        public string Headline { get; set; }


        /* Introduction */
        [DataMember(Name = "introduction", EmitDefaultValue = false)]
        public string Introduction { get; set; }


        /* Advice */
        [DataMember(Name = "advice", EmitDefaultValue = false)]
        public string Advice { get; set; }


        /* Chapters */
        [DataMember(Name = "chapters", EmitDefaultValue = false)]
        public List<Chapter> Chapters { get; set; }


        /* Array of Photos */
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        public List<Photo> Photos { get; set; }


        /* Array of Videos */
        [DataMember(Name = "videos", EmitDefaultValue = false)]
        public List<Video> Videos { get; set; }



        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullDestination {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");

            sb.Append("  Location: ").Append(Location).Append("\n");

            sb.Append("  Title: ").Append(Title).Append("\n");

            sb.Append("  Headline: ").Append(Headline).Append("\n");

            sb.Append("  Introduction: ").Append(Introduction).Append("\n");

            sb.Append("  Advice: ").Append(Advice).Append("\n");

            sb.Append("  Chapters: ").Append(Chapters).Append("\n");

            sb.Append("  Photos: ").Append(Photos).Append("\n");

            sb.Append("  Videos: ").Append(Videos).Append("\n");

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
