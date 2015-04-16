using System.Collections.Generic;
using System.ComponentModel;
using LeagueOfLegends.Model.General;
using LeagueOfLegends.Model.Spell;
using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    [JsonObject("champion")]
    public class Champion : BaseDto
    {
        [JsonProperty("active")]
        [Description("Indicates if the champion is active.")]
        public bool Active { get; set; }

        [JsonProperty("allytips")]
        public string[] AllyTips { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("enemytips")]
        public string[] EnemyTips { get; set; }

        [JsonProperty("freeToPlay")]
        [Description("Indicates if the champion is free to play. Free to play champions are rotated periodically.")]
        public bool FreeToPlay { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("info")]
        public Information Information { get; set; }

        [JsonProperty("botEnabled")]
        [Description("Bot enabled flag (for custom games).")]
        public bool IsBotEnabled { get; set; }

        [JsonProperty("botMmEnabled")]
        [Description("Bot Match Made enabled flag (for Co-op vs. AI games).")]
        public bool IsBotMmEnabled { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partype")]
        public string ParType { get; set; }

        [JsonProperty("passive")]
        public Passive Passive { get; set; }

        [JsonProperty("rankedPlayEnabled")]
        [Description("Ranked play enabled flag.")]
        public bool RankedPlayEnabled { get; set; }

        [JsonProperty("recommended")]
        public List<Recommended> Recommended { get; set; }

        // TODO: Properly set type.
        [JsonProperty("skins")]
        public string Skins { get; set; }

        [JsonProperty("spells")]
        public List<Spell.Spell> Spells { get; set; }

        [JsonProperty("stats")]
        public Stat Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}