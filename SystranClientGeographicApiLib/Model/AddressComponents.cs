using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.GeographicClientLib.Model {

  /// <summary>
  /// Address components
  /// </summary>
  [DataContract]
  public class AddressComponents {
    
    /* Country */
    [DataMember(Name="country", EmitDefaultValue=false)]
    public string Country { get; set; }

    
    /* State */
    [DataMember(Name="state", EmitDefaultValue=false)]
    public string State { get; set; }

    
    /* County */
    [DataMember(Name="county", EmitDefaultValue=false)]
    public string County { get; set; }

    
    /* City */
    [DataMember(Name="city", EmitDefaultValue=false)]
    public string City { get; set; }

    
    /* District */
    [DataMember(Name="district", EmitDefaultValue=false)]
    public string District { get; set; }

    
    /* Postal code */
    [DataMember(Name="postalCode", EmitDefaultValue=false)]
    public string PostalCode { get; set; }

    
    /* Street */
    [DataMember(Name="street", EmitDefaultValue=false)]
    public string Street { get; set; }

    
    /* House */
    [DataMember(Name="house", EmitDefaultValue=false)]
    public string House { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddressComponents {\n");
      
      sb.Append("  Country: ").Append(Country).Append("\n");
      
      sb.Append("  State: ").Append(State).Append("\n");
      
      sb.Append("  County: ").Append(County).Append("\n");
      
      sb.Append("  City: ").Append(City).Append("\n");
      
      sb.Append("  District: ").Append(District).Append("\n");
      
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      
      sb.Append("  Street: ").Append(Street).Append("\n");
      
      sb.Append("  House: ").Append(House).Append("\n");
      
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