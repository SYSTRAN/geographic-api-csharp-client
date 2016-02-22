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
            inspirationApi = new InspirationsApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(inspirationApi.apiClient.basePath, typeof(string));
        }



        [TestMethod()]
        public void GeographicInspirationsListGet()
        {
            InspirationResponse inspirationResponse = inspirationApi.GeographicInspirationsListGet(null, null, null, null, null, null, null, null, null, null, null, null, null);
            Assert.IsNotNull(inspirationResponse.Total);
        }

        [TestMethod()]
        public void GeographicInspirationsListGetAsyncTest()
        {
            InspirationResponse inspirationResponse = new InspirationResponse();
            Task.Run(async () =>
            {
                inspirationResponse = await inspirationApi.GeographicInspirationsListGetAsync(null, null, null, null, null, null, null, null, null, null, null, null, null);
            }).Wait();

            Assert.IsNotNull(inspirationResponse.Total);

        }


        [TestMethod()]
        public void GeographicInspirationsGetTest()
        {
            InspirationResponse inspirationResponse = inspirationApi.GeographicInspirationsListGet(null, null, null, null, null, null, null, null, null, null, null, null, null);

            InspirationDetailsResponse inspirationDetailsResponse = inspirationApi.GeographicInspirationsGetGet(inspirationResponse.Inspirations[0].Id, null, null);
            Assert.IsNotNull(inspirationDetailsResponse.Result);
        }

        [TestMethod()]
        public void GeographicInspirationsGetAsyncTest()
        {
            InspirationResponse inspirationResponse = inspirationApi.GeographicInspirationsListGet(null, null, null, null, null, null, null, null, null, null, null, null, null);

            InspirationDetailsResponse inspirationDetailsResponse = new InspirationDetailsResponse();
            Task.Run(async () =>
            {
                 inspirationDetailsResponse = await inspirationApi.GeographicInspirationsGetGetAsync(inspirationResponse.Inspirations[0].Id, null, null);
            }).Wait();

            Assert.IsNotNull(inspirationDetailsResponse.Result);
            
        }
    }
}