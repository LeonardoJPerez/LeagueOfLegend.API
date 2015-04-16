using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using LeagueOfLegends.WebServices.Net.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LeagueOfLegends.WebServices.Net.Response
{
    [DataContract]
    public class BaseResponse : IResponse
    {
        [DataMember(Name = "data")]
        [JsonProperty("data")]
        public dynamic Data { get; set; }

        [DataMember(Name = "type")]
        [JsonProperty("type")]
        public string Type { get; set; }

        [DataMember(Name = "version")]
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets the JSON Data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetData<T>()
        {
            var obj = (T)Activator.CreateInstance(typeof(T));
            var JsonConverterList = new List<JsonConverter>();

            if (this.Data != null)
            {
                if (this.Data is JArray)
                {
                    var jray = ((JArray)this.Data).ToString();
                    return JsonConvert.DeserializeObject<T>(jray);
                }
                return JsonConvert.DeserializeObject<T>(((JObject)this.Data).ToString());
            }
            return obj;
        }
    }
}