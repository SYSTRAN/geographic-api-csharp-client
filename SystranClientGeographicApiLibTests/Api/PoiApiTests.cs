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
    public class PoiApiTests
    {

        private static ApiClient client;
        private static POIApi poiApi;

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
            poiApi = new POIApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(poiApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void GeographicPoiGetListTest()
        {
            PoiResponse poiResponse =  poiApi.GeographicPoiListGet(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null) ;   
            Assert.IsNotNull(poiResponse.PointsOfInterest);
        }

        [TestMethod()]
        public void GeographicPoiGetListAsyncTest()
        {
            PoiResponse poiResponse = new PoiResponse();
            Task.Run(async () =>
            {
                poiResponse =  await poiApi.GeographicPoiListGetAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            }).Wait();
            Assert.IsNotNull(poiResponse.PointsOfInterest);
        }

        [TestMethod()]
        public void GeographicPoiDetailsGetTest()
        {
            PoiResponse poiResponse = poiApi.GeographicPoiListGet(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            PoiDetailsResponse poilDetailsResponse = poiApi.GeographicPoiGetGet(poiResponse.PointsOfInterest[0].Id,
               null, null);
            Assert.IsNotNull(poilDetailsResponse);
        }

        [TestMethod()]
        public void GeographicPoiDetailsGetAsyncTest()
        {
            PoiResponse poiResponse = poiApi.GeographicPoiListGet(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            PoiDetailsResponse poilDetailsResponse = new PoiDetailsResponse() ;
            Task.Run(async () =>
            {
                poilDetailsResponse = await poiApi.GeographicPoiGetGetAsync(poiResponse.PointsOfInterest[0].Id, null, null);
            }).Wait();
            Assert.IsNotNull(poilDetailsResponse);
        }
     
        [TestMethod()]
        public void GeographicPoiTypesGetTest()
        {
            PoiTypesResponse poiTypesResponse = poiApi.GeographicPoiTypesGet(null, null);
            Assert.IsNotNull(poiTypesResponse.PoiTypes);
        }

        [TestMethod()]
        public void GeographicPoiTypesGetAsyncTest()
        {
            PoiTypesResponse poiTypesResponse = new PoiTypesResponse();
            Task.Run(async () =>
            {
                poiTypesResponse = await poiApi.GeographicPoiTypesGetAsync(null, null);
            }).Wait();
            Assert.IsNotNull(poiTypesResponse.PoiTypes);
        }
    }
}