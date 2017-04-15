using Newtonsoft.Json.Linq;
using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System.Collections.Generic;

namespace SimplyCastSync.DataSource
{
    public class SimplyCastWebApiDs : IDataSrc<JArray>
    {
        //public HttpClient Ds { get; private set; }

        public IQuery<JArray> Q { get; private set; }

        public ConfigItems<KeyValuePair<string, string>> Config { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Connect()
        {
            return false;
        }

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
        public SimplyCastWebApiDs()
        {
            //Ds = new HttpClient();
            Q = new SimplyCastWebApiQuery();
        }


    }
}
