using Newtonsoft.Json.Linq;
using SimplyCastSync.DBAccess;
using System;
using System.Net.Http;

namespace SimplyCastSync.DBAccess
{
    public class SimplyCastWebApiQuery : IQuery<JObject>, IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public HttpClient HC { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public JObject GetData(string querystr)
        {
            //Ds = default(JArray);
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public int UpdateData(JObject ds)
        {
            return 0;
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
        public SimplyCastWebApiQuery()
        {
            HC = new HttpClient();
            HC.BaseAddress = new Uri("");
            //HC.DefaultRequestHeaders

        }
    }
}
