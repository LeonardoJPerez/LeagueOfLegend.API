using System;

namespace LeagueOfLegends.Data.Attributes
{
    public class DisplayEnumAttribute : Attribute
    {
        private readonly string _title = string.Empty;

        public DisplayEnumAttribute(string title)
        {
            this._title = title;
        }

        public string ToLower()
        {
            return this._title.ToLower();
        }
    }
}