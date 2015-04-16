using LeagueOfLegends.Model.General;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    [JsonObject("passive")]
    public class Passive : BaseDto
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }
    }
}