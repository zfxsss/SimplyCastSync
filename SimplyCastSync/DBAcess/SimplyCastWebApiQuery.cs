using Newtonsoft.Json.Linq;
using SimplyCastSync.DBAccess;
using System;
using System.Net.Http;

namespace SimplyCastSync.DBAccess
{
    public class SimplyCastWebApiQuery : IQuery<JArray>, IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public JArray Ds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public HttpClient HC { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public JArray GetData(string querystr)
        {
            return default(JArray);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public int UpdateData(JArray ds)
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
