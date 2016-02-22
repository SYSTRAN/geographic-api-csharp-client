using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystranClientGeographicApiLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.GeographicClientLib.Client;
using System.IO;
using Systran.GeographicClientLib.Model;

namespace SystranClientGeographicApiLib.Api.Tests
{
    [TestClass()]
    public class DestinationsApiTests
    {
        private static ApiClient client;
        private static DestinationsApi destinationApi;

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
            destinationApi = new DestinationsApi(Configuration.apiClient);
        }
        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(destinationApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void GeographicDestinationsListGetTest()
        {
            DestinationResponse destinationResponse = new DestinationResponse();
            destinationResponse = destinationApi.GeographicDestinationsListGet(null, null, null, null, null, null, null, null, null, null, null, null, null);
            Assert.IsNotNull(destinationResponse.Total);
        }

        [TestMethod()]
        public void GeographicDestinationsListGetAsync()
        {

            DestinationResponse destinationResponse = new DestinationResponse();
            Task.Run(async () =>
            {
                destinationResponse = await destinationApi.GeographicDestinationsListGetAsync(null, null, null, null, null, null, null, null, null, null, null, null, null);
            }).Wait();

            Assert.IsNotNull(destinationResponse.Total);
        }

        [TestMethod()]
        public void GeographicDestinationsGetTest()
        {
            DestinationResponse destinationResponse = new DestinationResponse();
            destinationResponse = destinationApi.GeographicDestinationsListGet(null, null, null, null, null, null, null, null, null, null, null, null, null);

            DestinationDetailsResponse destinationDetailsResponse = new DestinationDetailsResponse();
            destinationDetailsResponse = destinationApi.GeographicDestinationsGetGet(destinationResponse.Destinations[0].Id, null, null);
            Assert.IsNotNull(destinationDetailsResponse.Result);
        }

        [TestMethod()]
        public void GeographicDestinationGetAsync()
        {
            DestinationResponse destinationResponse = new DestinationResponse();
            destinationResponse = destinationApi.GeographicDestinationsListGet(null, null, null, null, null, null, null, null, null, null, null, null, null);

            DestinationDetailsResponse destinationDetailsResponse = new DestinationDetailsResponse();
            Task.Run(async () =>
            {
                destinationDetailsResponse = await destinationApi.GeographicDestinationsGetGetAsync(destinationResponse.Destinations[0].Id, null, null);
            }).Wait();

            Assert.IsNotNull(destinationDetailsResponse.Result);
        }
    }
}