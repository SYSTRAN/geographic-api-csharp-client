using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.GeographicClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Client;
using System.IO;
using Systran.GeographicClientLib.Model;

namespace Systran.GeographicClientLib.Api.Tests
{
    [TestClass()]
    public class APIVersionApiTests
    {
        private static ApiClient client;
        private static APIVersionApi versionApi;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platform.systran.net:8904");
            Configuration.apiClient = client;
            if (!File.Exists("../../apiKey.txt"))
                throw new Exception("To properly run the tests, please add an apiKey.txt file containing your api key in the SystranClientRessourcesApiLibTests folder or edit the test file with your key");
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../apiKey.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key);
            if (keys.Count == 0)
                throw new Exception("No api key found, please check your apiKey.txt file");
            Configuration.apiKey = keys;
            versionApi = new APIVersionApi(Configuration.apiClient);
        }
        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(versionApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void GeographicApiVersionGetTest()
        {
            ApiVersionResponse apiVersionResponse = new ApiVersionResponse();
            apiVersionResponse = versionApi.GeographicApiVersionGet(null);
            Assert.IsNotNull(apiVersionResponse.Version);
        }

        [TestMethod()]
        public void GeographicApiVersionGetAsyncGetAsyncTest()
        {

            ApiVersionResponse apiVersionResponse = new ApiVersionResponse();
            Task.Run(async () =>
            {
            apiVersionResponse = await versionApi.GeographicApiVersionGetAsync(null);
            }).Wait();

            Assert.IsNotNull(apiVersionResponse.Version);     
        }
}
}