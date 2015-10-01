using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.GeographicClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Client;
using Systran.GeographicClientLib.Model;
using System.IO;

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
            client = new ApiClient("https://platform.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../apiKey.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key); Configuration.apiKey = keys; Configuration.apiKey = keys;
            inspirationApi = new InspirationsApi(Configuration.apiClient);
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