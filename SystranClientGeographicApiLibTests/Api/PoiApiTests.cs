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
        private static PoiApi poiApi;

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
            Configuration.apiKey = keys;
            poiApi = new PoiApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(poiApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void GeographicPoiGetTest()
        {
            PoiResponse poiResponse =  poiApi.GeographicPoiGet(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);   
            Assert.IsNotNull(poiResponse.PointsOfInterest);
        }

        [TestMethod()]
        public void GeographicPoiGetAsyncTest()
        {
            PoiResponse poiResponse = new PoiResponse();
            Task.Run(async () =>
            {
                poiResponse =  await poiApi.GeographicPoiGetAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            }).Wait();
            Assert.IsNotNull(poiResponse.PointsOfInterest);
        }

        [TestMethod()]
        public void GeographicPoiDetailsGetTest()
        {
           PoiDetailsResponse poilDetailsResponse = poiApi.GeographicPoiDetailsGet("556dd2b5d61c8170d8cd3ea8", null, null);
            Assert.IsNotNull(poilDetailsResponse.PoiDetails);
        }

        [TestMethod()]
        public void GeographicPoiDetailsGetAsyncTest()
        {
            PoiDetailsResponse poilDetailsResponse = new PoiDetailsResponse() ;
            Task.Run(async () =>
            {
                poilDetailsResponse = await poiApi.GeographicPoiDetailsGetAsync("556dd2b5d61c8170d8cd3ea8", null, null);
            }).Wait();
            Assert.IsNotNull(poilDetailsResponse.PoiDetails);
        }

        [TestMethod()]
        public void GeographicPoiEventsGetTest()
        {
           EventsResponse eventsResponse =  poiApi.GeographicPoiEventsGet(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
           Assert.IsNotNull(eventsResponse.Events);
        }

        [TestMethod()]
        public void GeographicPoiEventsGetAsyncTest()
        {
            EventsResponse eventsResponse = new EventsResponse();
            Task.Run(async () =>
            {
                eventsResponse = await poiApi.GeographicPoiEventsGetAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            }).Wait();
            Assert.IsNotNull(eventsResponse.Events);
        }

        [TestMethod()]
        public void GeographicPoiSupportedLanguagesGetTest()
        {
           SupportedLanguagesResponse supportedLanguagesResponse = poiApi.GeographicPoiSupportedLanguagesGet(null);
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void GeographicPoiSupportedLanguagesGetAsyncTest()
        {
            SupportedLanguagesResponse supportedLanguagesResponse = new SupportedLanguagesResponse();
            Task.Run(async () =>
            {
               supportedLanguagesResponse = await poiApi.GeographicPoiSupportedLanguagesGetAsync(null);
            }).Wait();
            Assert.IsNotNull(supportedLanguagesResponse.Languages);
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