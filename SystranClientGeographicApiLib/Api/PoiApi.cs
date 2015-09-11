using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;

namespace Systran.GeographicClientLib.Api {
  

  public interface IPoiApi {
    
    /// <summary>
    /// Get Point of interests\n Get `Point of interests`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiResponse</returns>
    PoiResponse GeographicPoiGet (double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback);

    /// <summary>
    /// Get Point of interests\n Get `Point of interests`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiResponse</returns>
    Task<PoiResponse> GeographicPoiGetAsync (double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback);
    
    /// <summary>
    /// Get Point of interest details Get `Point of interest` details.
    /// </summary>
    /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiDetailsResponse</returns>
    PoiDetailsResponse GeographicPoiDetailsGet (string Id, string AcceptLanguage, string Callback);

    /// <summary>
    /// Get Point of interest details Get `Point of interest` details.
    /// </summary>
    /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiDetailsResponse</returns>
    Task<PoiDetailsResponse> GeographicPoiDetailsGetAsync (string Id, string AcceptLanguage, string Callback);
    
    /// <summary>
    /// Get Events Get `Events`.\n\nThe main criteria can be:\n* opening dates\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Date">Date at which events are available</param>/// <param name="BeginDate">Date corresponding to the begining of the period where events are available</param>/// <param name="EndDate">Date corresponding to the end of the period where events are available</param>/// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>EventsResponse</returns>
    EventsResponse GeographicPoiEventsGet (DateTime? Date, DateTime? BeginDate, DateTime? EndDate, double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback);

    /// <summary>
    /// Get Events Get `Events`.\n\nThe main criteria can be:\n* opening dates\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Date">Date at which events are available</param>/// <param name="BeginDate">Date corresponding to the begining of the period where events are available</param>/// <param name="EndDate">Date corresponding to the end of the period where events are available</param>/// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>EventsResponse</returns>
    Task<EventsResponse> GeographicPoiEventsGetAsync (DateTime? Date, DateTime? BeginDate, DateTime? EndDate, double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback);
    
    /// <summary>
    /// Supported Languages List of languages in which POI can be localized.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    SupportedLanguagesResponse GeographicPoiSupportedLanguagesGet (string Callback);

    /// <summary>
    /// Supported Languages List of languages in which POI can be localized.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    Task<SupportedLanguagesResponse> GeographicPoiSupportedLanguagesGetAsync (string Callback);
    
    /// <summary>
    /// Get available Point of interest types Get available `Point of interest` types.
    /// </summary>
    /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiTypesResponse</returns>
    PoiTypesResponse GeographicPoiTypesGet (string AcceptLanguage, string Callback);

    /// <summary>
    /// Get available Point of interest types Get available `Point of interest` types.
    /// </summary>
    /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiTypesResponse</returns>
    Task<PoiTypesResponse> GeographicPoiTypesGetAsync (string AcceptLanguage, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class PoiApi : IPoiApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="PoiApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public PoiApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PoiApi"/> class.
    /// </summary>
    /// <returns></returns>
    public PoiApi(String basePath)
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
    /// Get Point of interests\n Get `Point of interests`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiResponse</returns>
    public PoiResponse GeographicPoiGet (double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback) {

      

      var path = "/geographic/poi";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Latitude != null) queryParams.Add("latitude", apiClient.ParameterToString(Latitude)); // query parameter
       if (Longitude != null) queryParams.Add("longitude", apiClient.ParameterToString(Longitude)); // query parameter
       if (Radius != null) queryParams.Add("radius", apiClient.ParameterToString(Radius)); // query parameter
       if (MaximumLatitude != null) queryParams.Add("maximumLatitude", apiClient.ParameterToString(MaximumLatitude)); // query parameter
       if (MaximumLongitude != null) queryParams.Add("maximumLongitude", apiClient.ParameterToString(MaximumLongitude)); // query parameter
       if (MinimumLatitude != null) queryParams.Add("minimumLatitude", apiClient.ParameterToString(MinimumLatitude)); // query parameter
       if (MinimumLongitude != null) queryParams.Add("minimumLongitude", apiClient.ParameterToString(MinimumLongitude)); // query parameter
       if (Filter != null) queryParams.Add("filter", apiClient.ParameterToString(Filter)); // query parameter
       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (MainType != null) queryParams.Add("mainType", apiClient.ParameterToString(MainType)); // query parameter
       if (Type != null) queryParams.Add("type", apiClient.ParameterToString(Type)); // query parameter
       if (Address != null) queryParams.Add("address", apiClient.ParameterToString(Address)); // query parameter
       if (Country != null) queryParams.Add("country", apiClient.ParameterToString(Country)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (County != null) queryParams.Add("county", apiClient.ParameterToString(County)); // query parameter
       if (City != null) queryParams.Add("city", apiClient.ParameterToString(City)); // query parameter
       if (District != null) queryParams.Add("district", apiClient.ParameterToString(District)); // query parameter
       if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
       if (Street != null) queryParams.Add("street", apiClient.ParameterToString(Street)); // query parameter
       if (House != null) queryParams.Add("house", apiClient.ParameterToString(House)); // query parameter
       if (RankBy != null) queryParams.Add("rankBy", apiClient.ParameterToString(RankBy)); // query parameter
       if (OpenNow != null) queryParams.Add("openNow", apiClient.ParameterToString(OpenNow)); // query parameter
       if (MinimumRating != null) queryParams.Add("minimumRating", apiClient.ParameterToString(MinimumRating)); // query parameter
       if (MaximumRating != null) queryParams.Add("maximumRating", apiClient.ParameterToString(MaximumRating)); // query parameter
       if (MinimumPrice != null) queryParams.Add("minimumPrice", apiClient.ParameterToString(MinimumPrice)); // query parameter
       if (MaximumPrice != null) queryParams.Add("maximumPrice", apiClient.ParameterToString(MaximumPrice)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiGet: " + response.Content, response.Content);
      }
      return (PoiResponse) apiClient.Deserialize(response.Content, typeof(PoiResponse));
    }
	
	 /// <summary>
    /// Get Point of interests\n Get `Point of interests`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiResponse</returns>
    public async Task<PoiResponse> GeographicPoiGetAsync (double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback) {

      

      var path = "/geographic/poi";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Latitude != null) queryParams.Add("latitude", apiClient.ParameterToString(Latitude)); // query parameter
       if (Longitude != null) queryParams.Add("longitude", apiClient.ParameterToString(Longitude)); // query parameter
       if (Radius != null) queryParams.Add("radius", apiClient.ParameterToString(Radius)); // query parameter
       if (MaximumLatitude != null) queryParams.Add("maximumLatitude", apiClient.ParameterToString(MaximumLatitude)); // query parameter
       if (MaximumLongitude != null) queryParams.Add("maximumLongitude", apiClient.ParameterToString(MaximumLongitude)); // query parameter
       if (MinimumLatitude != null) queryParams.Add("minimumLatitude", apiClient.ParameterToString(MinimumLatitude)); // query parameter
       if (MinimumLongitude != null) queryParams.Add("minimumLongitude", apiClient.ParameterToString(MinimumLongitude)); // query parameter
       if (Filter != null) queryParams.Add("filter", apiClient.ParameterToString(Filter)); // query parameter
       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (MainType != null) queryParams.Add("mainType", apiClient.ParameterToString(MainType)); // query parameter
       if (Type != null) queryParams.Add("type", apiClient.ParameterToString(Type)); // query parameter
       if (Address != null) queryParams.Add("address", apiClient.ParameterToString(Address)); // query parameter
       if (Country != null) queryParams.Add("country", apiClient.ParameterToString(Country)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (County != null) queryParams.Add("county", apiClient.ParameterToString(County)); // query parameter
       if (City != null) queryParams.Add("city", apiClient.ParameterToString(City)); // query parameter
       if (District != null) queryParams.Add("district", apiClient.ParameterToString(District)); // query parameter
       if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
       if (Street != null) queryParams.Add("street", apiClient.ParameterToString(Street)); // query parameter
       if (House != null) queryParams.Add("house", apiClient.ParameterToString(House)); // query parameter
       if (RankBy != null) queryParams.Add("rankBy", apiClient.ParameterToString(RankBy)); // query parameter
       if (OpenNow != null) queryParams.Add("openNow", apiClient.ParameterToString(OpenNow)); // query parameter
       if (MinimumRating != null) queryParams.Add("minimumRating", apiClient.ParameterToString(MinimumRating)); // query parameter
       if (MaximumRating != null) queryParams.Add("maximumRating", apiClient.ParameterToString(MaximumRating)); // query parameter
       if (MinimumPrice != null) queryParams.Add("minimumPrice", apiClient.ParameterToString(MinimumPrice)); // query parameter
       if (MaximumPrice != null) queryParams.Add("maximumPrice", apiClient.ParameterToString(MaximumPrice)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiGet: " + response.Content, response.Content);
      }
      return (PoiResponse) apiClient.Deserialize(response.Content, typeof(PoiResponse));
    }
    
    /// <summary>
    /// Get Point of interest details Get `Point of interest` details.
    /// </summary>
    /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiDetailsResponse</returns>
    public PoiDetailsResponse GeographicPoiDetailsGet (string Id, string AcceptLanguage, string Callback) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling GeographicPoiDetailsGet");
      

      var path = "/geographic/poi/details";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Id != null) queryParams.Add("id", apiClient.ParameterToString(Id)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiDetailsGet: " + response.Content, response.Content);
      }
      return (PoiDetailsResponse) apiClient.Deserialize(response.Content, typeof(PoiDetailsResponse));
    }
	
	 /// <summary>
    /// Get Point of interest details Get `Point of interest` details.
    /// </summary>
    /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiDetailsResponse</returns>
    public async Task<PoiDetailsResponse> GeographicPoiDetailsGetAsync (string Id, string AcceptLanguage, string Callback) {

      
          // verify the required parameter 'Id' is set
          if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling GeographicPoiDetailsGet");
      

      var path = "/geographic/poi/details";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Id != null) queryParams.Add("id", apiClient.ParameterToString(Id)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiDetailsGet: " + response.Content, response.Content);
      }
      return (PoiDetailsResponse) apiClient.Deserialize(response.Content, typeof(PoiDetailsResponse));
    }
    
    /// <summary>
    /// Get Events Get `Events`.\n\nThe main criteria can be:\n* opening dates\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Date">Date at which events are available</param>/// <param name="BeginDate">Date corresponding to the begining of the period where events are available</param>/// <param name="EndDate">Date corresponding to the end of the period where events are available</param>/// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>EventsResponse</returns>
    public EventsResponse GeographicPoiEventsGet (DateTime? Date, DateTime? BeginDate, DateTime? EndDate, double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback) {

      

      var path = "/geographic/poi/events";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Date != null) queryParams.Add("date", apiClient.ParameterToString(Date)); // query parameter
       if (BeginDate != null) queryParams.Add("beginDate", apiClient.ParameterToString(BeginDate)); // query parameter
       if (EndDate != null) queryParams.Add("endDate", apiClient.ParameterToString(EndDate)); // query parameter
       if (Latitude != null) queryParams.Add("latitude", apiClient.ParameterToString(Latitude)); // query parameter
       if (Longitude != null) queryParams.Add("longitude", apiClient.ParameterToString(Longitude)); // query parameter
       if (Radius != null) queryParams.Add("radius", apiClient.ParameterToString(Radius)); // query parameter
       if (MaximumLatitude != null) queryParams.Add("maximumLatitude", apiClient.ParameterToString(MaximumLatitude)); // query parameter
       if (MaximumLongitude != null) queryParams.Add("maximumLongitude", apiClient.ParameterToString(MaximumLongitude)); // query parameter
       if (MinimumLatitude != null) queryParams.Add("minimumLatitude", apiClient.ParameterToString(MinimumLatitude)); // query parameter
       if (MinimumLongitude != null) queryParams.Add("minimumLongitude", apiClient.ParameterToString(MinimumLongitude)); // query parameter
       if (Filter != null) queryParams.Add("filter", apiClient.ParameterToString(Filter)); // query parameter
       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (MainType != null) queryParams.Add("mainType", apiClient.ParameterToString(MainType)); // query parameter
       if (Type != null) queryParams.Add("type", apiClient.ParameterToString(Type)); // query parameter
       if (Address != null) queryParams.Add("address", apiClient.ParameterToString(Address)); // query parameter
       if (Country != null) queryParams.Add("country", apiClient.ParameterToString(Country)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (County != null) queryParams.Add("county", apiClient.ParameterToString(County)); // query parameter
       if (City != null) queryParams.Add("city", apiClient.ParameterToString(City)); // query parameter
       if (District != null) queryParams.Add("district", apiClient.ParameterToString(District)); // query parameter
       if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
       if (Street != null) queryParams.Add("street", apiClient.ParameterToString(Street)); // query parameter
       if (House != null) queryParams.Add("house", apiClient.ParameterToString(House)); // query parameter
       if (RankBy != null) queryParams.Add("rankBy", apiClient.ParameterToString(RankBy)); // query parameter
       if (OpenNow != null) queryParams.Add("openNow", apiClient.ParameterToString(OpenNow)); // query parameter
       if (MinimumRating != null) queryParams.Add("minimumRating", apiClient.ParameterToString(MinimumRating)); // query parameter
       if (MaximumRating != null) queryParams.Add("maximumRating", apiClient.ParameterToString(MaximumRating)); // query parameter
       if (MinimumPrice != null) queryParams.Add("minimumPrice", apiClient.ParameterToString(MinimumPrice)); // query parameter
       if (MaximumPrice != null) queryParams.Add("maximumPrice", apiClient.ParameterToString(MaximumPrice)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiEventsGet: " + response.Content, response.Content);
      }
      return (EventsResponse) apiClient.Deserialize(response.Content, typeof(EventsResponse));
    }
	
	 /// <summary>
    /// Get Events Get `Events`.\n\nThe main criteria can be:\n* opening dates\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
    /// </summary>
    /// <param name="Date">Date at which events are available</param>/// <param name="BeginDate">Date corresponding to the begining of the period where events are available</param>/// <param name="EndDate">Date corresponding to the end of the period where events are available</param>/// <param name="Latitude">Latitude location</param>/// <param name="Longitude">Longitude location</param>/// <param name="Radius">Radius in meters</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="District">POI district</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="House">POI house</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating</param>/// <param name="MaximumRating">Maximum rating</param>/// <param name="MinimumPrice">Minumum price</param>/// <param name="MaximumPrice">Maximum price</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>EventsResponse</returns>
    public async Task<EventsResponse> GeographicPoiEventsGetAsync (DateTime? Date, DateTime? BeginDate, DateTime? EndDate, double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string District, string PostalCode, string Street, string House, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback) {

      

      var path = "/geographic/poi/events";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Date != null) queryParams.Add("date", apiClient.ParameterToString(Date)); // query parameter
       if (BeginDate != null) queryParams.Add("beginDate", apiClient.ParameterToString(BeginDate)); // query parameter
       if (EndDate != null) queryParams.Add("endDate", apiClient.ParameterToString(EndDate)); // query parameter
       if (Latitude != null) queryParams.Add("latitude", apiClient.ParameterToString(Latitude)); // query parameter
       if (Longitude != null) queryParams.Add("longitude", apiClient.ParameterToString(Longitude)); // query parameter
       if (Radius != null) queryParams.Add("radius", apiClient.ParameterToString(Radius)); // query parameter
       if (MaximumLatitude != null) queryParams.Add("maximumLatitude", apiClient.ParameterToString(MaximumLatitude)); // query parameter
       if (MaximumLongitude != null) queryParams.Add("maximumLongitude", apiClient.ParameterToString(MaximumLongitude)); // query parameter
       if (MinimumLatitude != null) queryParams.Add("minimumLatitude", apiClient.ParameterToString(MinimumLatitude)); // query parameter
       if (MinimumLongitude != null) queryParams.Add("minimumLongitude", apiClient.ParameterToString(MinimumLongitude)); // query parameter
       if (Filter != null) queryParams.Add("filter", apiClient.ParameterToString(Filter)); // query parameter
       if (Name != null) queryParams.Add("name", apiClient.ParameterToString(Name)); // query parameter
       if (MainType != null) queryParams.Add("mainType", apiClient.ParameterToString(MainType)); // query parameter
       if (Type != null) queryParams.Add("type", apiClient.ParameterToString(Type)); // query parameter
       if (Address != null) queryParams.Add("address", apiClient.ParameterToString(Address)); // query parameter
       if (Country != null) queryParams.Add("country", apiClient.ParameterToString(Country)); // query parameter
       if (State != null) queryParams.Add("state", apiClient.ParameterToString(State)); // query parameter
       if (County != null) queryParams.Add("county", apiClient.ParameterToString(County)); // query parameter
       if (City != null) queryParams.Add("city", apiClient.ParameterToString(City)); // query parameter
       if (District != null) queryParams.Add("district", apiClient.ParameterToString(District)); // query parameter
       if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
       if (Street != null) queryParams.Add("street", apiClient.ParameterToString(Street)); // query parameter
       if (House != null) queryParams.Add("house", apiClient.ParameterToString(House)); // query parameter
       if (RankBy != null) queryParams.Add("rankBy", apiClient.ParameterToString(RankBy)); // query parameter
       if (OpenNow != null) queryParams.Add("openNow", apiClient.ParameterToString(OpenNow)); // query parameter
       if (MinimumRating != null) queryParams.Add("minimumRating", apiClient.ParameterToString(MinimumRating)); // query parameter
       if (MaximumRating != null) queryParams.Add("maximumRating", apiClient.ParameterToString(MaximumRating)); // query parameter
       if (MinimumPrice != null) queryParams.Add("minimumPrice", apiClient.ParameterToString(MinimumPrice)); // query parameter
       if (MaximumPrice != null) queryParams.Add("maximumPrice", apiClient.ParameterToString(MaximumPrice)); // query parameter
       if (Limit != null) queryParams.Add("limit", apiClient.ParameterToString(Limit)); // query parameter
       if (Offset != null) queryParams.Add("offset", apiClient.ParameterToString(Offset)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiEventsGet: " + response.Content, response.Content);
      }
      return (EventsResponse) apiClient.Deserialize(response.Content, typeof(EventsResponse));
    }
    
    /// <summary>
    /// Supported Languages List of languages in which POI can be localized.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public SupportedLanguagesResponse GeographicPoiSupportedLanguagesGet (string Callback) {

      

      var path = "/geographic/poi/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of languages in which POI can be localized.
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguagesResponse</returns>
    public async Task<SupportedLanguagesResponse> GeographicPoiSupportedLanguagesGetAsync (string Callback) {

      

      var path = "/geographic/poi/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
    }
    
    /// <summary>
    /// Get available Point of interest types Get available `Point of interest` types.
    /// </summary>
    /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiTypesResponse</returns>
    public PoiTypesResponse GeographicPoiTypesGet (string AcceptLanguage, string Callback) {

      

      var path = "/geographic/poi/types";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiTypesGet: " + response.Content, response.Content);
      }
      return (PoiTypesResponse) apiClient.Deserialize(response.Content, typeof(PoiTypesResponse));
    }
	
	 /// <summary>
    /// Get available Point of interest types Get available `Point of interest` types.
    /// </summary>
    /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>PoiTypesResponse</returns>
    public async Task<PoiTypesResponse> GeographicPoiTypesGetAsync (string AcceptLanguage, string Callback) {

      

      var path = "/geographic/poi/types";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
       if (AcceptLanguage != null) headerParams.Add("Accept-Language", apiClient.ParameterToString(AcceptLanguage)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GeographicPoiTypesGet: " + response.Content, response.Content);
      }
      return (PoiTypesResponse) apiClient.Deserialize(response.Content, typeof(PoiTypesResponse));
    }
    
  }  
  
}
