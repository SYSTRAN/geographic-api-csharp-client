using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Model;

namespace Systran.GeographicClientLib.Model
{

    /// <summary>
    /// Destination
    /// </summary>
    [DataContract]
    public partial class Destination : IEquatable<Destination>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination" /> class.
        /// </summary>
        public Destination()
        {

        }


        /// <summary>
        /// Destination identifier
        /// </summary>
        /// <value>Destination identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }


        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }


        /// <summary>
        /// Content
        /// </summary>
        /// <value>Content</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }


        /// <summary>
        /// Array of Photos
        /// </summary>
        /// <value>Array of Photos</value>
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        public List<Photo> Photos { get; set; }


        /// <summary>
        /// Array of Videos
        /// </summary>
        /// <value>Array of Videos</value>
        [DataMember(Name = "videos", EmitDefaultValue = false)]
        public List<Video> Videos { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Destination {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Destination);
        }

        /// <summary>
        /// Returns true if Destination instances are equal
        /// </summary>
        /// <param name="other">Instance of Destination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.Photos == other.Photos ||
                    this.Photos != null &&
                    this.Photos.SequenceEqual(other.Photos)
                ) &&
                (
                    this.Videos == other.Videos ||
                    this.Videos != null &&
                    this.Videos.SequenceEqual(other.Videos)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                if (this.Photos != null)
                    hash = hash * 59 + this.Photos.GetHashCode();

                if (this.Videos != null)
                    hash = hash * 59 + this.Videos.GetHashCode();

                return hash;
            }
        }

    }
}

