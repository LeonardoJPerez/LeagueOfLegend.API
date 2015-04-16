using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    [JsonObject("recommended")]
    public class Recommended : BaseDto
    {
        [JsonProperty("blocks")]
        public List<Block> Blocks { get; set; }

        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("priority")]
        public bool Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}