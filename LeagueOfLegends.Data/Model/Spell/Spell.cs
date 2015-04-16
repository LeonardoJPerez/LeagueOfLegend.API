using System.Collections.Generic;
using LeagueOfLegends.Model.Champion;
using LeagueOfLegends.Model.General;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Spell
{
    [JsonObject("spell")]
    public class Spell : BaseDto
    {
        [JsonProperty("altimages")]
        public List<Image> AltImages { get; set; }

        [JsonProperty("cooldown")]
        public List<double> CoolDown { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CoolDownBurn { get; set; }

        [JsonProperty("cost")]
        public List<int> Cost { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("effect")]
        public List<object> Effect { get; set; }

        [JsonProperty("effectBurn")]
        public List<string> EffectBurn { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("leveltip")]
        public LevelTip LevelTip { get; set; }

        [JsonProperty("maxrank")]
        public int MaxRank { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("range")]
        public object Range { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("vars")]
        public List<SpellVars> Vars { get; set; }
    }
}