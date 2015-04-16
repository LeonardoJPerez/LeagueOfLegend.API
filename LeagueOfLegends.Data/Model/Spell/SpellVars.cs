using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Spell
{
    [JsonObject("vars")]
    public class SpellVars : BaseDto
    {
        [JsonProperty("coeff")]
        public List<double> CoEfficient { get; set; }

        [JsonProperty("dyn")]
        public string Dyn { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("ranksWith")]
        public string RanksWith { get; set; }
    }
}