using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimplyCastSync.DBAccess;
using SimplyCastSync.Config;

namespace SimplyCastSync.DataSource
{
    public class DbSrc : ConfigReader, IDataSrc
    {
        /// <summary>
        /// 
        /// </summary>
        public IQuery Ds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSrc(string dsname)
        {
            GetConfiguration("");
        }


    }
}
