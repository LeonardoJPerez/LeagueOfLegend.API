﻿using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    [JsonObject("info")]
    public class Information : BaseDto
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("magic")]
        public int Magic { get; set; }
    }
}