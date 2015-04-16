using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    public class Block : BaseDto
    {
        [JsonProperty("items")]
        public List<BlockItem> Items { get; set; }

        [JsonProperty("recMath")]
        public bool RecMath { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}