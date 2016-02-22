using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;

namespace SystranClientGeographicApiLib.Api
{


    public interface IDestinationsApi
    {

        /// <summary>
        /// Get specific destination Get a specific `Destination`.
        /// </summary>
        /// <param name="Id">Destination identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationDetailsResponse</returns>
        DestinationDetailsResponse GeographicDestinationsGetGet(string Id, string AcceptLanguage, string Callback);

        /// <summary>
        /// Get specific destination Get a specific `Destination`.
        /// </summary>
        /// <param name="Id">Destination identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationDetailsResponse</returns>
        Task<DestinationDetailsResponse> GeographicDestinationsGetGetAsync(string Id, string AcceptLanguage, string Callback);

        /// <summary>
        /// List destinations Get a list of `Destinations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationResponse</returns>
        DestinationResponse GeographicDestinationsListGet(double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback);

        /// <summary>
        /// List destinations Get a list of `Destinations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationResponse</returns>
        Task<DestinationResponse> GeographicDestinationsListGetAsync(double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DestinationsApi : IDestinationsApi
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)
        /// <returns></returns>
        public DestinationsApi(ApiClient apiClient = null)
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
        /// Initializes a new instance of the <see cref="DestinationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DestinationsApi(String basePath)
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
        /// Get specific destination Get a specific `Destination`.
        /// </summary>
        /// <param name="Id">Destination identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationDetailsResponse</returns>
        public DestinationDetailsResponse GeographicDestinationsGetGet(string Id, string AcceptLanguage, string Callback)
        {


            // verify the required parameter 'Id' is set
            if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling GeographicDestinationsGetGet");


            var path = "/geographic/destinations/get";
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
                throw new ApiException((int)response.StatusCode, "Error calling GeographicDestinationsGetGet: " + response.Content, response.Content);
            }
            return (DestinationDetailsResponse)apiClient.Deserialize(response.Content, typeof(DestinationDetailsResponse));
        }

        /// <summary>
        /// Get specific destination Get a specific `Destination`.
        /// </summary>
        /// <param name="Id">Destination identifier</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationDetailsResponse</returns>
        public async Task<DestinationDetailsResponse> GeographicDestinationsGetGetAsync(string Id, string AcceptLanguage, string Callback)
        {


            // verify the required parameter 'Id' is set
            if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling GeographicDestinationsGetGet");


            var path = "/geographic/destinations/get";
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
                throw new ApiException((int)response.StatusCode, "Error calling GeographicDestinationsGetGet: " + response.Content, response.Content);
            }
            return (DestinationDetailsResponse)apiClient.Deserialize(response.Content, typeof(DestinationDetailsResponse));
        }

        /// <summary>
        /// List destinations Get a list of `Destinations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationResponse</returns>
        public DestinationResponse GeographicDestinationsListGet(double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback)
        {



            var path = "/geographic/destinations/list";
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
            if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
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
                throw new ApiException((int)response.StatusCode, "Error calling GeographicDestinationsListGet: " + response.Content, response.Content);
            }
            return (DestinationResponse)apiClient.Deserialize(response.Content, typeof(DestinationResponse));
        }

        /// <summary>
        /// List destinations Get a list of `Destinations`.\n\nThe main criteria can be:\n* a position and a radius\n* a textual search\n\nAdditional critera can be added.\n
        /// </summary>
        /// <param name="Latitude">Latitude location. Musts be used together with `longitude` and `radius` parameters.</param>/// <param name="Longitude">Longitude location. Musts be used together with `latitude` and `radius` parameters.</param>/// <param name="Radius">Radius in meters. Musts be used together with `latitude` and `longitude` parameters.</param>/// <param name="Address">Address</param>/// <param name="Country">Country</param>/// <param name="State">State</param>/// <param name="County">County</param>/// <param name="City">City</param>/// <param name="PostalCode">Postal Code</param>/// <param name="Limit">Pagination limit</param>/// <param name="Offset">Pagination offset</param>/// <param name="AcceptLanguage">Preferred languages for response localization.\n\nSee [Accept-Language header specification for HTTP\n1.1](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.4)\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>DestinationResponse</returns>
        public async Task<DestinationResponse> GeographicDestinationsListGetAsync(double? Latitude, double? Longitude, double? Radius, string Address, string Country, string State, string County, string City, string PostalCode, int? Limit, int? Offset, string AcceptLanguage, string Callback)
        {



            var path = "/geographic/destinations/list";
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
            if (PostalCode != null) queryParams.Add("postalCode", apiClient.ParameterToString(PostalCode)); // query parameter
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
                throw new ApiException((int)response.StatusCode, "Error calling GeographicDestinationsListGet: " + response.Content, response.Content);
            }
            return (DestinationResponse)apiClient.Deserialize(response.Content, typeof(DestinationResponse));
        }

    }

}