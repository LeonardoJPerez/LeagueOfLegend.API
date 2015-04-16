using System.Runtime.Serialization;
using LeagueOfLegends.WebServices.Properties;
using Newtonsoft.Json;

namespace LeagueOfLegends.WebServices.Net.Request
{
    [DataContract]
    public class ChampionRequest : BaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChampionRequest"/> class.
        /// </summary>
        public ChampionRequest()
        {
            this.UrlOperation = Resources.Operation_Champion;
            this.Version = Resources.StaticDataVersion; 
    
            // TODO: Needs to create additional request layer for specific API sections to handle APIUrlFormat. 
            this.APIUrlFormat = Resources.StatisDataUrlFormat;
        }

        [DataMember(Name = "keys")]
        [JsonProperty("keys")]
        public dynamic Keys { get; set; }

        [DataMember(Name = "type")]
        [JsonProperty("type")]
        public string Type { get; set; }        

        [DataMember(Name = "version")]
        [JsonProperty("version")]
        public override string Version { get; set; }
    }
}