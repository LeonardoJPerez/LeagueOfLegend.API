using LeagueOfLegends.WebServices.Filter;
using LeagueOfLegends.WebServices.Net.Interface;
using LeagueOfLegends.WebServices.Properties;

namespace LeagueOfLegends.WebServices.Net.Request
{
    public abstract class BaseRequest : IRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequest"/> class.
        /// </summary>
        public BaseRequest()
        {
            this.Method = "GET";
            this.ContentType = "application/json; charset=UTF-8";
            this.BaseUrl = Resources.BaseUrl;
            this.Region = FilterSettings.RegionEnum.NA;
        }

        public virtual string APIUrlFormat { get; set; }

        public virtual string BaseUrl { get; protected set; }

        public string ContentType { get; set; }

        public virtual string DataID { get; set; }

        public string Method { get; set; }

        public Query QueryParamaters { get; set; }

        public FilterSettings.RegionEnum Region { get; set; }

        public virtual string RequestUrl
        {
            get
            {
                if (!string.IsNullOrEmpty(this.DataID))
                {
                    UrlOperation = string.Format("{0}/{1}", UrlOperation, this.DataID);
                }

                return string.Format("{0}/{1}", this.BaseUrl, string.Format(this.APIUrlFormat, this.Region.ToString().ToLower(), this.Version, this.UrlOperation));
            }
            protected set { }
        }

        public virtual string UrlOperation { get; protected set; }

        public virtual string Version { get; set; }
    }
}