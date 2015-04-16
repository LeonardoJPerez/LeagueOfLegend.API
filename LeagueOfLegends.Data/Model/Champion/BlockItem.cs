using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    public class BlockItem : BaseDto
    {
        [JsonProperty("count")]
        public int Count { get; set; } 
    }
}
