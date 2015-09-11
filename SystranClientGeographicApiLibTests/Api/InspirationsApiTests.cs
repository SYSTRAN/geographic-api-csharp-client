using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.GeographicClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;
namespace Systran.GeographicClientLib.Api.Tests
{
    [TestClass()]
    public class InspirationsApiTests
    {

        private static ApiClient client;
        private static InspirationsApi inspirationApi;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platformapi-stag.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            keys.Add("key", "a72c2f99-5841-4259-88a6-f75f9860f992");
            Configuration.apiKey = keys;
            inspirationApi = new InspirationsApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void InspirationsApiTest()
        {

        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(inspirationApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void GeographicInspirationsGetTest()
        {
            InspirationResponse inspirationResponse = inspirationApi.GeographicInspirationsGet(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            Assert.IsNotNull(inspirationResponse.Total);
        }

        [TestMethod()]
        public void GeographicInspirationsGetAsyncTest()
        {
            InspirationResponse inspirationResponse = new InspirationResponse();
            Task.Run(async () =>
            {
                inspirationResponse = await inspirationApi.GeographicInspirationsGetAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            }).Wait();

            Assert.IsNotNull(inspirationResponse.Total);
            
        }
    }
}