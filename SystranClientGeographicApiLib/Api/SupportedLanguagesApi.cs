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


    public interface ISupportedLanguagesApi
    {

        /// <summary>
        /// Get Supported languages Get a list of languages in which geographic data can be localized.
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>SupportedLanguagesResponse</returns>
        SupportedLanguagesResponse GeographicSupportedLanguagesGet(string Callback);

        /// <summary>
        /// Get Supported languages Get a list of languages in which geographic data can be localized.
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>SupportedLanguagesResponse</returns>
        Task<SupportedLanguagesResponse> GeographicSupportedLanguagesGetAsync(string Callback);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SupportedLanguagesApi : ISupportedLanguagesApi
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedLanguagesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)
        /// <returns></returns>
        public SupportedLanguagesApi(ApiClient apiClient = null)
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
        /// Initializes a new instance of the <see cref="SupportedLanguagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SupportedLanguagesApi(String basePath)
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
        /// Get Supported languages Get a list of languages in which geographic data can be localized.
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>SupportedLanguagesResponse</returns>
        public SupportedLanguagesResponse GeographicSupportedLanguagesGet(string Callback)
        {



            var path = "/geographic/supportedLanguages";
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
                throw new ApiException((int)response.StatusCode, "Error calling GeographicSupportedLanguagesGet: " + response.Content, response.Content);
            }
            return (SupportedLanguagesResponse)apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
        }

        /// <summary>
        /// Get Supported languages Get a list of languages in which geographic data can be localized.
        /// </summary>
        /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
        /// <returns>SupportedLanguagesResponse</returns>
        public async Task<SupportedLanguagesResponse> GeographicSupportedLanguagesGetAsync(string Callback)
        {



            var path = "/geographic/supportedLanguages";
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
                throw new ApiException((int)response.StatusCode, "Error calling GeographicSupportedLanguagesGet: " + response.Content, response.Content);
            }
            return (SupportedLanguagesResponse)apiClient.Deserialize(response.Content, typeof(SupportedLanguagesResponse));
        }

    }

}