using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;

namespace Systran.GeographicClientLib.Api {


    public interface IPOIApi
    {

        /// <summary>
        /// Get specific point of interest Get a specific `Point of interest`.
        /// </summary>
        /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiDetailsResponse</returns>
        PoiDetailsResponse GeographicPoiGetGet(string Id, string AcceptLanguage, string Callback);

        /// <summary>
        /// Get specific point of interest Get a specific `Point of interest`.
        /// </summary>
        /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiDetailsResponse</returns>
        Task<PoiDetailsResponse> GeographicPoiGetGetAsync(string Id, string AcceptLanguage, string Callback);

        /// <summary>
        /// List points of interest\n Get a list of `Points of interest`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box. Musts be used together with `maximumLongitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box. Musts be used together with `maximumLatitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLatitude` parameters.</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating (from 1 to 5)</param>/// <param name="MaximumRating">Maximum rating (from 1 to 5)</param>/// <param name="MinimumPrice">Minimum price level (from 0 to 3)</param>/// <param name="MaximumPrice">Maximum price level (from 0 to 3)</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiResponse</returns>
        PoiResponse GeographicPoiListGet(double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string PostalCode, string Street, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback);

        /// <summary>
        /// List points of interest\n Get a list of `Points of interest`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box. Musts be used together with `maximumLongitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box. Musts be used together with `maximumLatitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLatitude` parameters.</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating (from 1 to 5)</param>/// <param name="MaximumRating">Maximum rating (from 1 to 5)</param>/// <param name="MinimumPrice">Minimum price level (from 0 to 3)</param>/// <param name="MaximumPrice">Maximum price level (from 0 to 3)</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiResponse</returns>
        Task<PoiResponse> GeographicPoiListGetAsync(double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string PostalCode, string Street, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback);

        /// <summary>
        /// Get available point of interest types Get available `Point of interest` types.
        /// </summary>
        /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiTypesResponse</returns>
        PoiTypesResponse GeographicPoiTypesGet(string AcceptLanguage, string Callback);

        /// <summary>
        /// Get available point of interest types Get available `Point of interest` types.
        /// </summary>
        /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiTypesResponse</returns>
        Task<PoiTypesResponse> GeographicPoiTypesGetAsync(string AcceptLanguage, string Callback);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class POIApi : IPOIApi
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="POIApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)
        /// <returns></returns>
        public POIApi(ApiClient apiClient = null)
        {
            if (apiClient == null)
            { // use the default one in Configuration
                this.apiClient = Configuration.apiClient;
            }
            else
            {
                this.apiClient = apiClient;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="POIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public POIApi(String basePath)
        {
            this.apiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.apiClient.basePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.apiClient.basePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>The API client</value>
        public ApiClient apiClient { get; set; }



        /// <summary>
        /// Get specific point of interest Get a specific `Point of interest`.
        /// </summary>
        /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiDetailsResponse</returns>
        public PoiDetailsResponse GeographicPoiGetGet(string Id, string AcceptLanguage, string Callback)
        {


            // verify the required parameter 'Id' is set
            if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling GeographicPoiGetGet");


            var path = "/geographic/poi/get";
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
            IRestResponse response = (IRestResponse)apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicPoiGetGet: " + response.Content, response.Content);
            }
            return (PoiDetailsResponse)apiClient.Deserialize(response.Content, typeof(PoiDetailsResponse));
        }

        /// <summary>
        /// Get specific point of interest Get a specific `Point of interest`.
        /// </summary>
        /// <param name="Id">POI identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiDetailsResponse</returns>
        public async Task<PoiDetailsResponse> GeographicPoiGetGetAsync(string Id, string AcceptLanguage, string Callback)
        {


            // verify the required parameter 'Id' is set
            if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling GeographicPoiGetGet");


            var path = "/geographic/poi/get";
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
            IRestResponse response = (IRestResponse)await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicPoiGetGet: " + response.Content, response.Content);
            }
            return (PoiDetailsResponse)apiClient.Deserialize(response.Content, typeof(PoiDetailsResponse));
        }

        /// <summary>
        /// List points of interest\n Get a list of `Points of interest`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box. Musts be used together with `maximumLongitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box. Musts be used together with `maximumLatitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLatitude` parameters.</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating (from 1 to 5)</param>/// <param name="MaximumRating">Maximum rating (from 1 to 5)</param>/// <param name="MinimumPrice">Minimum price level (from 0 to 3)</param>/// <param name="MaximumPrice">Maximum price level (from 0 to 3)</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiResponse</returns>
        public PoiResponse GeographicPoiListGet(double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string PostalCode, string Street, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback)
        {



            var path = "/geographic/poi/list";
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
            if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
            if (Street != null) queryParams.Add("street", apiClient.ParameterToString(Street)); // query parameter
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
            IRestResponse response = (IRestResponse)apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicPoiListGet: " + response.Content, response.Content);
            }
            return (PoiResponse)apiClient.Deserialize(response.Content, typeof(PoiResponse));
        }

        /// <summary>
        /// List points of interest\n Get a list of `Points of interest`.\n\nThe main criteria can be:\n* a position and a radius\n* a bounding box\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="MaximumLatitude">Latitude of the top (northernmost) side of the bounding box. Musts be used together with `maximumLongitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MaximumLongitude">Longitude of the right (easternmost) side of the bounding box. Musts be used together with `maximumLatitude`, `minimumLatitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLatitude">Latitude of the bottom (southernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLongitude` parameters.</param>/// <param name="MinimumLongitude">Longitude of the left (westernmost) side of the bounding box. Musts be used together with `maximumLatitude`, `maximumLongitude` and `minimumLatitude` parameters.</param>/// <param name="Filter">Filter on all relevent POI data (name, type, address, ...)</param>/// <param name="Name">POI name</param>/// <param name="MainType">POI main type</param>/// <param name="Type">POI type</param>/// <param name="Address">POI address</param>/// <param name="Country">POI country</param>/// <param name="State">POI state</param>/// <param name="County">POI county</param>/// <param name="City">POI city</param>/// <param name="PostalCode">POI postal code</param>/// <param name="Street">POI street</param>/// <param name="RankBy">Ranking criteria</param>/// <param name="OpenNow">Only open for business POI</param>/// <param name="MinimumRating">Minimum rating (from 1 to 5)</param>/// <param name="MaximumRating">Maximum rating (from 1 to 5)</param>/// <param name="MinimumPrice">Minimum price level (from 0 to 3)</param>/// <param name="MaximumPrice">Maximum price level (from 0 to 3)</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiResponse</returns>
        public async Task<PoiResponse> GeographicPoiListGetAsync(double? Latitude, double? Longitude, double? Radius, double? MaximumLatitude, double? MaximumLongitude, double? MinimumLatitude, double? MinimumLongitude, List<string> Filter, List<string> Name, string MainType, List<string> Type, string Address, string Country, string State, string County, string City, string PostalCode, string Street, string RankBy, bool? OpenNow, int? MinimumRating, int? MaximumRating, int? MinimumPrice, int? MaximumPrice, int? Limit, int? Offset, string AcceptLanguage, string Callback)
        {



            var path = "/geographic/poi/list";
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
            if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
            if (Street != null) queryParams.Add("street", apiClient.ParameterToString(Street)); // query parameter
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
            IRestResponse response = (IRestResponse)await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicPoiListGet: " + response.Content, response.Content);
            }
            return (PoiResponse)apiClient.Deserialize(response.Content, typeof(PoiResponse));
        }

        /// <summary>
        /// Get available point of interest types Get available `Point of interest` types.
        /// </summary>
        /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiTypesResponse</returns>
        public PoiTypesResponse GeographicPoiTypesGet(string AcceptLanguage, string Callback)
        {



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
            IRestResponse response = (IRestResponse)apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicPoiTypesGet: " + response.Content, response.Content);
            }
            return (PoiTypesResponse)apiClient.Deserialize(response.Content, typeof(PoiTypesResponse));
        }

        /// <summary>
        /// Get available point of interest types Get available `Point of interest` types.
        /// </summary>
        /// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>PoiTypesResponse</returns>
        public async Task<PoiTypesResponse> GeographicPoiTypesGetAsync(string AcceptLanguage, string Callback)
        {



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
            IRestResponse response = (IRestResponse)await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicPoiTypesGet: " + response.Content, response.Content);
            }
            return (PoiTypesResponse)apiClient.Deserialize(response.Content, typeof(PoiTypesResponse));
        }

    }

}
