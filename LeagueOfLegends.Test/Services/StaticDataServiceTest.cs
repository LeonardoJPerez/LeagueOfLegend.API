using System.Collections.Generic;
using System.Configuration;
using LeagueOfLegends.WebServices;
using LeagueOfLegends.WebServices.Filter;
using LeagueOfLegends.WebServices.Services;
using NUnit.Framework;

namespace LeagueOfLegends.Test
{
    [TestFixture]
    public class StaticDataServiceTest
    {
        public LoLConfiguration _configuration { get; set; }

        public StaticDataService _service { get; set; }

        [TearDown]
        public void Dispose() { }

        [SetUp]
        public void Init()
        {
            this._configuration = new LoLConfiguration() { APIKey = ConfigurationManager.AppSettings["APIKey"] };
            this._service = new StaticDataService(_configuration);
        }

        #region Sync Tests

        // Test case set to use Champion id 412 (Thresh)
        [TestCase(412)]
        public void TestChampion(int championId)
        {
            var champion = _service.GetChampion(championId);

            Assert.IsNotNull(champion);
            Assert.AreEqual("Thresh", champion.Name);
        }

        [TestCase]
        public void TestChampions()
        {
            var champions = _service.GetChampions();

            Assert.IsNotNull(champions);
            Assert.Greater(champions.Count, 0);
        }

        // Test case set to use Champion id 412 (Thresh)
        [TestCase(412)]
        public void TestChampionWithQuery(int championId)
        {
            Query q = new Query();
            q.Items.Add(FilterSettings.QueryParameterEnum.ChampData, new List<string> { "all" });
            var champion = _service.GetChampion(championId);

            Assert.IsNotNull(champion);
            Assert.AreEqual("Thresh", champion.Name);
        }

        [TestCase]
        public void TestChampionsWithQuery()
        {
            var champions = _service.GetChampions();

            Assert.IsNotNull(champions);
            Assert.Greater(champions.Count, 0);
        }

        #endregion Sync Tests

        #region Async Tests

        // Test case set to use Champion id 412 (Thresh)
        [TestCase(412)]
        public void TestChampionAsync(int championId)
        {
            var champion = _service.GetChampionAsync(championId);

            Assert.IsNotNull(champion.Result);
            Assert.AreEqual("Thresh", champion.Result.Name);
        }

        [TestCase]
        public void TestChampionsAsync()
        {
            var champions = _service.GetChampionsAsync();

            Assert.IsNotNull(champions.Result);
            Assert.Greater(champions.Result.Count, 0);
        }

        #endregion Async Tests
    }
}