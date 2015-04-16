using LeagueOfLegends.Model.Champion;
using LeagueOfLegends.WebServices.Filter;
using LeagueOfLegends.WebServices.Net.Interface;
using LeagueOfLegends.WebServices.Net.Request;
using LeagueOfLegends.WebServices.Net.Response;
using LeagueOfLegends.WebServices.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueOfLegends.WebServices
{
    public class StaticDataService : LoLService
    {
        #region Private Members

        private IRequest _request;

        #endregion Private Members

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticDataService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public StaticDataService(string apiKey)
            : base(new LoLConfiguration { APIKey = apiKey })
        {
            this.InitService();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticDataService"/> class.
        /// </summary>
        /// <param name="_configuration">The _configuration.</param>
        public StaticDataService(LoLConfiguration _configuration)
            : base(_configuration)
        {
            this.InitService();
        }

        private void InitService()
        {
        }

        #region Champion Operations

        public Champion GetChampion(int championId, FilterSettings.RegionEnum region)
        {
            return this.GetChampion(championId, null, region);
        }

        public Champion GetChampion(int championId)
        {
            return this.GetChampion(championId, null);
        }

        public Champion GetChampion(int championId, Query query, FilterSettings.RegionEnum region = FilterSettings.RegionEnum.NA)
        {
            this._request = new ChampionRequest();
            this._request.Region = region;
            this._request.QueryParamaters = query;
            this._request.DataID = championId.ToString();
            return this.Get<Champion>(_request);
        }

        public async Task<Champion> GetChampionAsync(int championId)
        {
            return await this.GetChampionAsync(championId, null);
        }

        public async Task<Champion> GetChampionAsync(int championId, FilterSettings.RegionEnum region)
        {
            return await this.GetChampionAsync(championId, null, region);
        }

        public async Task<Champion> GetChampionAsync(int championId, Query query, FilterSettings.RegionEnum region = FilterSettings.RegionEnum.NA)
        {
            this._request = new ChampionRequest();
            this._request.Region = region;
            this._request.QueryParamaters = query;
            this._request.DataID = championId.ToString();
            return await this.GetAsync<Champion>(_request);
        }

        public Dictionary<string, Champion> GetChampions(FilterSettings.RegionEnum region)
        {
            return this.GetChampions(null, region);
        }

        public Dictionary<string, Champion> GetChampions()
        {
            return this.GetChampions(FilterSettings.RegionEnum.NA);
        }

        public Dictionary<string, Champion> GetChampions(Query query, FilterSettings.RegionEnum region = FilterSettings.RegionEnum.NA)
        {
            this._request = new ChampionRequest();
            this._request.Region = region;
            this._request.QueryParamaters = query;
            ChampionsResponse response = this.Get<ChampionsResponse>(_request);

            Dictionary<string, Champion> champions = new Dictionary<string, Champion>();
            if (response != null && response.Data != null)
            {
                champions = response.GetData<Dictionary<string, Champion>>();
            }

            return champions;
        }

        public async Task<Dictionary<string, Champion>> GetChampionsAsync(FilterSettings.RegionEnum region = FilterSettings.RegionEnum.NA)
        {
            return await this.GetChampionsAsync(null, region);
        }

        public async Task<Dictionary<string, Champion>> GetChampionsAsync()
        {
            return await this.GetChampionsAsync(null, FilterSettings.RegionEnum.NA);
        }

        public async Task<Dictionary<string, Champion>> GetChampionsAsync(Query query, FilterSettings.RegionEnum region = FilterSettings.RegionEnum.NA)
        {
            this._request = new ChampionRequest();
            this._request.Region = region;
            this._request.QueryParamaters = query;
            ChampionsResponse response = await this.GetAsync<ChampionsResponse>(_request);

            Dictionary<string, Champion> champions = new Dictionary<string, Champion>();
            if (response != null && response.Data != null)
            {
                champions = response.GetData<Dictionary<string, Champion>>();
            }

            return champions;
        }

        #endregion Champion Operations

        // TODO: Implement Static Data Get methods for different LoL API entites.
    }
}