namespace LeagueOfLegends.WebServices.Net.Interface
{
    public interface IResponse
    {
        dynamic Data { get; set; }

        string Type { get; set; }

        string Version { get; set; }

        /// <summary>
        /// Gets the JSON Data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetData<T>();
    }
}