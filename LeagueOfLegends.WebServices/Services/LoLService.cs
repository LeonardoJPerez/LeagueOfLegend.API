using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using LeagueOfLegends.Data.Filters;
using LeagueOfLegends.WebServices.Extensions;
using LeagueOfLegends.WebServices.Net.Interface;
using LeagueOfLegends.WebServices.Net.Request;
using Newtonsoft.Json;

namespace LeagueOfLegends.WebServices.Services
{
    public class LoLService : ILoLService
    {
        #region Private Members

        /// <summary>
        /// The Filters Collection
        /// </summary>
        protected FilterCollection _filters;

        protected string _url;

        /// <summary>
        /// All done
        /// </summary>
        private static ManualResetEvent _allDone = new ManualResetEvent(false);

        /// <summary>
        /// The response string
        /// </summary>
        private static string _responseString = "";

        #endregion Private Members

        /// <summary>
        /// The LF Configuration Object
        /// </summary>
        private static LoLConfiguration _serviceConfiguration = null;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoLService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public LoLService(LoLConfiguration configuration)
        {
            _serviceConfiguration = configuration;
        }

        #endregion Constructors

        #region Private Methods

        /// <summary>
        /// Initializes the request.
        /// </summary>
        /// <param name="apiRequest">The API request.</param>
        private void InitRequest(IRequest apiRequest)
        {
            if (_serviceConfiguration == null)
            {
                throw new ArgumentNullException("ServiceConfiguration");
            }

            if (string.IsNullOrEmpty(_serviceConfiguration.APIKey))
            {
                throw new ArgumentNullException("ServiceConfiguration.APIKey");
            }

            string queryString = string.Format("api_key={0}", _serviceConfiguration.APIKey);

            // Add QueryString parameters if any.
            if (apiRequest.QueryParamaters != null && apiRequest.QueryParamaters.Items.Count > 0)
            {
                queryString = apiRequest.QueryParamaters.GetQueryString();
            }

            switch (apiRequest.Method)
            {
                case "GET":
                    this._url = string.Format("{0}?{1}", apiRequest.RequestUrl, queryString);
                    break;

                default:
                    break;
            }
        }

        #endregion Private Methods

        #region Async Methods

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <typeparam name="T">The response type.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(Net.Interface.IRequest request)
        {
            InitRequest(request);

            try
            {
                var authRequest = (HttpWebRequest)HttpWebRequest.Create(this._url);
                authRequest.Method = request.Method;
                //authRequest.ContentType = apiRequest.ContentType;

                HttpWebResponse response = await authRequest.GetResponseAsyncCustom();

                // TODO: Implement response codes.
                using (Stream streamResponse = response.GetResponseStream())
                using (StreamReader streamRead = new StreamReader(streamResponse))
                {
                    _responseString = streamRead.ReadToEnd();
                }
            }
            catch (Exception)
            {
                // TODO: Catch request exception.
                throw;
            }

            return JsonConvert.DeserializeObject<T>(_responseString);
        }

        #endregion Async Methods

        #region Synchronous Methods

        /// <summary>
        /// Gets the specified request.
        /// </summary>
        /// <typeparam name="T">The response type.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public T Get<T>(IRequest request)
        {
            InitRequest(request);

            try
            {
                var authRequest = (HttpWebRequest)HttpWebRequest.Create(this._url);
                authRequest.Method = request.Method;
                authRequest.ContentType = request.ContentType;

                HttpWebResponse response = authRequest.GetResponseCustom();

                using (Stream streamResponse = response.GetResponseStream())
                using (StreamReader streamRead = new StreamReader(streamResponse))
                {
                    _responseString = streamRead.ReadToEnd();

                    if (Debugger.IsAttached)
                    {
                        Console.WriteLine(_responseString);
                    }
                }
            }
            catch (Exception)
            {
                // TODO: Implement logging mechanism.
                throw;
            }

            return JsonConvert.DeserializeObject<T>(_responseString);
        }

        #endregion Synchronous Methods
    }
}