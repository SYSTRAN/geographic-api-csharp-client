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
    public class SupportedLanguagesApiTests
    {
        private static ApiClient client;
        private static SupportedLanguagesApi supportedLanguagesApi;

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
            supportedLanguagesApi = new SupportedLanguagesApi(Configuration.apiClient);
        }


        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(supportedLanguagesApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void GeographicSupportedLanguagesGetTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = supportedLanguagesApi.GeographicSupportedLanguagesGet(null);
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void GeographicSupportedLanguagesGetAsyncTest() {

            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            Task.Run(async () =>
            {
                supportedLanguagesResponse = await supportedLanguagesApi.GeographicSupportedLanguagesGetAsync(null);
            }).Wait();

            Assert.IsNotNull(supportedLanguagesResponse.Languages);

        }
    }
}