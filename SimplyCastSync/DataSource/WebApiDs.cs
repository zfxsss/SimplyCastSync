using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DataSource
{
    public class WebApiDs : ConfigReader, IDataSrc
    {
        /// <summary>
        /// 
        /// </summary>
        public IQuery Ds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dsname"></param>
        public WebApiDs(string dsname)
        {
            GetConfiguration("");
        }


    }
}
