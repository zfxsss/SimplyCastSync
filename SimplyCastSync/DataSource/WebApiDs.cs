using Newtonsoft.Json.Linq;
using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DataSource
{
    public class WebApiDs : IDataSrc
    {
        public DataSrcType DsType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public IQuery<JArray> Ds
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dsname"></param>
        public WebApiDs(IQuery<JArray> ds)
        {
            Ds = ds;
        }


    }
}
