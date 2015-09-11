using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;

namespace Systran.GeographicClientLib.Api {
  

  public interface IInspirationsApi {
    
    /// <summary>
    /// Get Inspirations Get `Inspirations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="District">District</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>InspirationResponse</returns>
    InspirationResponse GeographicInspirationsGet (double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string District, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback);

    /// <summary>
    /// Get Inspirations Get `Inspirations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="District">District</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>InspirationResponse</returns>
    Task<InspirationResponse> GeographicInspirationsGetAsync (double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string District, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class InspirationsApi : IInspirationsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="InspirationsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public InspirationsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InspirationsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public InspirationsApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Get Inspirations Get `Inspirations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="District">District</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>InspirationResponse</returns>
    public InspirationResponse GeographicInspirationsGet (double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string District, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback) {

      

      var path = "/geographic/inspirations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Latitude != null) queryParams.Add("latitude", apiClient.ParameterToString(Latitude)); // query parameter
       if (Longitude != null) queryParams.Add("longitude", apiClient.ParameterToString(Longitude)); // query parameter
       if (Radius != null) queryParams.Add("radius", apiClient.ParameterToString(Radius)); // query parameter
       if (Address != null) queryParams.Add("address", apiClient.ParameterToString(Address)); // query parameter
       if (Country != null) queryParams.Add("country", apiClient.ParameterToString(Country)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (County != null) queryParams.Add("county", apiClient.ParameterToString(County)); // query parameter
       if (City != null) queryParams.Add("city", apiClient.ParameterToString(City)); // query parameter
       if (District != null) queryParams.Add("district", apiClient.ParameterToString(District)); // query parameter
       if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicInspirationsGet: " + response.Content, response.Content);
      }
      return (InspirationResponse) apiClient.Deserialize(response.Content, typeof(InspirationResponse));
    }
	
	 /// <summary>
    /// Get Inspirations Get `Inspirations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="District">District</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>InspirationResponse</returns>
    public async Task<InspirationResponse> GeographicInspirationsGetAsync (double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string District, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback) {

      

      var path = "/geographic/inspirations";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Latitude != null) queryParams.Add("latitude", apiClient.ParameterToString(Latitude)); // query parameter
       if (Longitude != null) queryParams.Add("longitude", apiClient.ParameterToString(Longitude)); // query parameter
       if (Radius != null) queryParams.Add("radius", apiClient.ParameterToString(Radius)); // query parameter
       if (Address != null) queryParams.Add("address", apiClient.ParameterToString(Address)); // query parameter
       if (Country != null) queryParams.Add("country", apiClient.ParameterToString(Country)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (County != null) queryParams.Add("county", apiClient.ParameterToString(County)); // query parameter
       if (City != null) queryParams.Add("city", apiClient.ParameterToString(City)); // query parameter
       if (District != null) queryParams.Add("district", apiClient.ParameterToString(District)); // query parameter
       if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicInspirationsGet: " + response.Content, response.Content);
      }
      return (InspirationResponse) apiClient.Deserialize(response.Content, typeof(InspirationResponse));
    }
    
  }  
  
}
