using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    [JsonObject("leveltip")]
    public class LevelTip : BaseDto
    {
        [JsonProperty("effect")]
        public List<string> Effect { get; set; }

        [JsonProperty("label")]
        public List<string> Label { get; set; }
    }
}