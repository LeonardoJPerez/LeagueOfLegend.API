using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegends.WebServices.Filter
{
    public class Query : IQuery
    {
        private Dictionary<FilterSettings.QueryParameterEnum, IEnumerable<string>> _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        public Query()
        {
            this._items = new Dictionary<FilterSettings.QueryParameterEnum, IEnumerable<string>>();
        }

        public Dictionary<FilterSettings.QueryParameterEnum, IEnumerable<string>> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Gets the query string.
        /// </summary>
        /// <returns></returns>
        public string GetQueryString()
        {
            StringBuilder q = new StringBuilder();

            if (this._items.Count == 0)
            {
                return q.ToString();
            }

            foreach (var kvp in this._items)
            {
                var filters = string.Join(",", kvp.Value);
                q.AppendFormat("{0}={1}&", kvp.Key.ToString().ToLower(), filters);
            }

            return q.ToString();
        }
    }
}