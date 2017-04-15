using Newtonsoft.Json.Linq;
using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System.Collections.Generic;

namespace SimplyCastSync.DataSource
{
    public class WebApiDs : IDataSrc<JArray>
    {
        //public HttpClient Ds { get; private set; }

        public IQuery<JArray> Q { get; private set; }

        public ConfigItems<KeyValuePair<string, string>> Config { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dsname"></param>
        public WebApiDs(IQuery<JArray> q, ConfigItems<KeyValuePair<string, string>> config)
        {
            //Q = new SimplyCastWebApiQuery();
            Q = q;
            Config = config;
        }


    }
}
