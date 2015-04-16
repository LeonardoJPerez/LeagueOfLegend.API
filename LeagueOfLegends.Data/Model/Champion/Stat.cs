using Newtonsoft.Json;

namespace LeagueOfLegends.Model.Champion
{
    public class Stat : BaseDto
    {
        [JsonProperty("armor")]
        public double Armor { get; set; }

        [JsonProperty("armorperlevel")]
        public double ArmorPerLevel { get; set; }

        [JsonProperty("attackdamage")]
        public double AttackDamage { get; set; }

        [JsonProperty("attackdamageperlevel")]
        public double AttackDamagePerLevel { get; set; }

        [JsonProperty("attackrange")]
        public double AttackRange { get; set; }

        [JsonProperty("attackspeedoffset")]
        public double AttackSpeedOffset { get; set; }

        [JsonProperty("attackspeedperlevel")]
        public double AttackSpeedPerLevel { get; set; }

        [JsonProperty("crit")]
        public double Critical { get; set; }

        [JsonProperty("critperlevel")]
        public double CriticalPerLevel { get; set; }

        [JsonProperty("hp")]
        public double HitPoints { get; set; }

        [JsonProperty("hpperlevel")]
        public double HitPointsPerLevel { get; set; }

        [JsonProperty("hpregen")]
        public double HitPointsRegen { get; set; }

        [JsonProperty("hpregenperlevel")]
        public double HitPointsRegenPerLevel { get; set; }

        [JsonProperty("mp")]
        public double MagicPoints { get; set; }

        [JsonProperty("mpperlevel")]
        public double MagicPointsPerLevel { get; set; }

        [JsonProperty("mpregen")]
        public double MagicPointsRegen { get; set; }

        [JsonProperty("mpregenperlevel")]
        public double MagicPointsRegenPerLevel { get; set; }

        [JsonProperty("movespeed")]
        public double MovementSpeed { get; set; }

        [JsonProperty("spellblock")]
        public double SpellBlock { get; set; }

        [JsonProperty("spellblockperlevel")]
        public double SpellBlockPerLevel { get; set; }
    }
}