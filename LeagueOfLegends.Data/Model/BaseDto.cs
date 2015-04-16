using Newtonsoft.Json;

namespace LeagueOfLegends.Model
{
    public class BaseDto
    {
        [JsonProperty("id")]
        public int Id { set; get; }
    }
}