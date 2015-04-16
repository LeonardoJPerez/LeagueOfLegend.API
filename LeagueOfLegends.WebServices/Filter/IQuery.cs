using System.Collections.Generic;

namespace LeagueOfLegends.WebServices.Filter
{
    public interface IQuery
    {    
        /// <summary>
        /// Gets the query string.
        /// </summary>
        /// <returns></returns>
        string GetQueryString();
    }
}