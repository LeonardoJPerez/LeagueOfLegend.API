using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LeagueOfLegends.WebServices.Net.Response
{
    [DataContract]
    public class ChampionsResponse : BaseResponse
    {
        [DataMember(Name = "format")]
        [JsonProperty("format")]
        public string Format { get; set; }

        [DataMember(Name = "keys")]
        [JsonProperty("keys")]
        public dynamic Keys { get; set; }
    }
}