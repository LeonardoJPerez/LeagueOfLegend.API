using Newtonsoft.Json;

namespace LeagueOfLegends.Model.General
{
    [JsonObject("image")]
    public class Image : BaseDto
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("h")]
        public int Height { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("w")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int xAxis { get; set; }

        [JsonProperty("y")]
        public int yAxis { get; set; }
    }
}