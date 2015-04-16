using System.Collections.Generic;

namespace LeagueOfLegends.Data.Filters
{
    public class FilterEqualityComparer : EqualityComparer<Filter>
    {
        public override bool Equals(Filter x, Filter y)
        {
            if (x.Name == y.Name && x.Value == y.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Filter obj)
        {
            var hash = string.Format("{0}{1}", obj.Name.Trim().ToLower(), obj.Value.Trim().ToLower());
            return hash.GetHashCode();
        }
    }
}