using System.Configuration;
using LeagueOfLegends.WebServices.Filter;
using LeagueOfLegends.WebServices.Net.Request;
using LeagueOfLegends.WebServices.Net.Response;
using LeagueOfLegends.WebServices.Services;
using NUnit.Framework;

namespace LeagueOfLegends.Test
{
    [TestFixture]
    public class LoLServiceTest
    {
        public LoLConfiguration _configuration { get; set; }

        // Using a specific request. API does not allow generic requests.
        public ChampionRequest _request { get; set; }

        public LoLService _service { get; set; }

        [TearDown]
        public void Dispose() { }

        [SetUp]
        public void Init()
        {
            this._configuration = new LoLConfiguration() { APIKey = ConfigurationManager.AppSettings["APIKey"] };
            this._service = new LoLService(_configuration);
            this._request = new ChampionRequest();
            this._request.APIUrlFormat = "static-data/{0}/{1}/{2}";
        }

        [TestCase]
        public void TestChampionRequestExplicit()
        {
            var apiResponse = _service.Get<ChampionsResponse>(_request);

            Assert.IsNotNull(apiResponse);
            Assert.AreEqual(apiResponse.Type, "champion");
        }

        [TestCase]
        public void TestChampionRequestExplicitAsync()
        {
            var task = _service.GetAsync<ChampionsResponse>(_request);
            task.Wait();

            Assert.IsNotNull(task.Result);
            Assert.AreEqual(task.Result.Type, "champion");
        }
    }
}