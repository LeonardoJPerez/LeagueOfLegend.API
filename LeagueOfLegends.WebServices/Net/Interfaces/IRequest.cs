using LeagueOfLegends.WebServices.Filter;

namespace LeagueOfLegends.WebServices.Net.Interface
{
    public interface IRequest
    {
        string APIUrlFormat { get; set; }

        string BaseUrl { get; }

        string ContentType { get; set; }

        string DataID { get; set; }

        string Method { get; set; }

        Query QueryParamaters { get; set; }

        FilterSettings.RegionEnum Region { get; set; }

        string RequestUrl { get; }

        string UrlOperation { get; }
    }
}