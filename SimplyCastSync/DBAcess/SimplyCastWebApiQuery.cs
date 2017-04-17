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
        private string _connstr;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public JObject GetData(string querystr)
        {

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
        public SimplyCastWebApiQuery(string connstr)
        {
            _connstr = connstr;

        }
    }
}
