using LeagueOfLegends.Data.Attributes;

namespace LeagueOfLegends.WebServices.Filter
{
    public static class FilterSettings
    {
        public enum ChampDataEnum
        {
            // TODO: May need to change.
            [DisplayEnumAttribute("all")]
            All,

            [DisplayEnumAttribute("allytips")]
            AllyTips,

            [DisplayEnumAttribute("altimages")]
            AltImages,

            [DisplayEnumAttribute("blurb")]
            Blurb,

            [DisplayEnumAttribute("enemytips")]
            EnemyTips,

            [DisplayEnumAttribute("image")]
            Image,

            [DisplayEnumAttribute("info")]
            Info,

            [DisplayEnumAttribute("lore")]
            Lore,

            [DisplayEnumAttribute("partype")]
            ParType,

            [DisplayEnumAttribute("passive")]
            Passive,

            [DisplayEnumAttribute("recommended")]
            Recommended,

            [DisplayEnumAttribute("skins")]
            Skins,

            [DisplayEnumAttribute("spells")]
            Spells,

            [DisplayEnumAttribute("stats")]
            Stats,

            [DisplayEnumAttribute("tags")]
            Tags
        }

        public enum LocaleEnum
        {
            [DisplayEnumAttribute("en_US")]
            EN_US,

            [DisplayEnumAttribute("es_ES")]
            ES_ES
        }

        public enum QueryParameterEnum
        {
            [DisplayEnumAttribute("locale")]
            Locale,

            [DisplayEnumAttribute("version")]
            Version,

            [DisplayEnumAttribute("dataById")]
            DataById,

            [DisplayEnumAttribute("champData")]
            ChampData
        }

        public enum RegionEnum
        {
            [DisplayEnumAttribute("br")]
            BR,

            [DisplayEnumAttribute("eune")]
            EUNE,

            [DisplayEnumAttribute("euw")]
            EUW,

            [DisplayEnumAttribute("kr")]
            KR,

            [DisplayEnumAttribute("lan")]
            LAN,

            [DisplayEnumAttribute("las")]
            LAS,

            [DisplayEnumAttribute("na")]
            NA,

            [DisplayEnumAttribute("oce")]
            OCE,

            [DisplayEnumAttribute("ru")]
            RU,

            [DisplayEnumAttribute("tr")]
            TR
        }
    }
}