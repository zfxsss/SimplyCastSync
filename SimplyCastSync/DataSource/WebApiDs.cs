using Newtonsoft.Json.Linq;
using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System.Collections.Generic;

namespace SimplyCastSync.DataSource
{
    public class WebApiDs : IDataSrc<JArray>
    {
        /// <summary>
        /// 
        /// </summary>
        public IQuery<JArray> Q { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ConfigItems<KeyValuePair<string, string>> Config { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public JArray Ds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jt"></param>
        public void AddRd(JToken jt)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jt"></param>
        public void UpdateRd(JToken jt)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jt"></param>
        public void RemoveRd(JToken jt)
        {

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
        public WebApiDs(IQuery<JArray> q, ConfigItems<KeyValuePair<string, string>> config)
        {
            //Q = new SimplyCastWebApiQuery();
            Q = q;
            Config = config;

            Ds = Q.GetData("");

            //Q.UpdateData(Ds);
        }


    }
}
