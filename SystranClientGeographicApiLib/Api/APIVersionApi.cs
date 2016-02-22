using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;

namespace Systran.GeographicClientLib.Api
{

    public interface IAPIVersionApi
    {

        /// <summary>
        /// Get API version Current version for geographic apis\n
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>ApiVersionResponse</returns>
        ApiVersionResponse GeographicApiVersionGet(string Callback);

        /// <summary>
        /// Get API version Current version for geographic apis\n
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>ApiVersionResponse</returns>
        Task<ApiVersionResponse> GeographicApiVersionGetAsync(string Callback);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class APIVersionApi : IAPIVersionApi
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="APIVersionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)
        /// <returns></returns>
        public APIVersionApi(ApiClient apiClient = null)
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
        /// Initializes a new instance of the <see cref="APIVersionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIVersionApi(String basePath)
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
        /// Get API version Current version for geographic apis\n
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>ApiVersionResponse</returns>
        public ApiVersionResponse GeographicApiVersionGet(string Callback)
        {



            var path = "/geographic/apiVersion";
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
            IRestResponse response = (IRestResponse)apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicApiVersionGet: " + response.Content, response.Content);
            }
            return (ApiVersionResponse)apiClient.Deserialize(response.Content, typeof(ApiVersionResponse));
        }

        /// <summary>
        /// Get API version Current version for geographic apis\n
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>ApiVersionResponse</returns>
        public async Task<ApiVersionResponse> GeographicApiVersionGetAsync(string Callback)
        {



            var path = "/geographic/apiVersion";
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
            IRestResponse response = (IRestResponse)await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
            if (((int)response.StatusCode) >= 400)
            {
                throw new ApiException((int)response.StatusCode, "Error calling GeographicApiVersionGet: " + response.Content, response.Content);
            }
            return (ApiVersionResponse)apiClient.Deserialize(response.Content, typeof(ApiVersionResponse));
        }

    }

}
