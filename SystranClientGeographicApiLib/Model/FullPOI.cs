using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// POI with detailled information
  /// </summary>
  [DataContract]
  public class FullPOI {
    
    /* POI Identifier */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Location */
    [DataMember(Name="location", EmitDefaultValue=false)]
    public FullLocation Location { get; set; }

    
    /* Name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Types, ordered from general to specific */
    [DataMember(Name="types", EmitDefaultValue=false)]
    public List<string> Types { get; set; }

    
    /* Rating */
    [DataMember(Name="rating", EmitDefaultValue=false)]
    public int? Rating { get; set; }

    
    /* Price Level */
    [DataMember(Name="priceLevel", EmitDefaultValue=false)]
    public int? PriceLevel { get; set; }

    
    /* Contact */
    [DataMember(Name="contact", EmitDefaultValue=false)]
    public Contact Contact { get; set; }

    
    /* Open Now */
    [DataMember(Name="openNow", EmitDefaultValue=false)]
    public bool? OpenNow { get; set; }

    
    /* Opening Hours */
    [DataMember(Name="openingHours", EmitDefaultValue=false)]
    public List<OpeningHours> OpeningHours { get; set; }

    
    /* Array of Photos */
    [DataMember(Name="photos", EmitDefaultValue=false)]
    public List<Photo> Photos { get; set; }

    
    /* POI */
    [DataMember(Name="url", EmitDefaultValue=false)]
    public string Url { get; set; }

    
    /* Description content splitted in several parts */
    [DataMember(Name="descriptions", EmitDefaultValue=false)]
    public List<Description> Descriptions { get; set; }

    
    /* Reviews */
    [DataMember(Name="reviews", EmitDefaultValue=false)]
    public List<Review> Reviews { get; set; }

    
    /* Booking */
    [DataMember(Name="booking", EmitDefaultValue=false)]
    public Booking Booking { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FullPOI {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Location: ").Append(Location).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Types: ").Append(Types).Append("\n");
      
      sb.Append("  Rating: ").Append(Rating).Append("\n");
      
      sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
      
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      
      sb.Append("  OpenNow: ").Append(OpenNow).Append("\n");
      
      sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
      
      sb.Append("  Photos: ").Append(Photos).Append("\n");
      
      sb.Append("  Url: ").Append(Url).Append("\n");
      
      sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
      
      sb.Append("  Reviews: ").Append(Reviews).Append("\n");
      
      sb.Append("  Booking: ").Append(Booking).Append("\n");
      
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