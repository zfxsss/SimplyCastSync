using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimplyCastSync.DBAccess;
using SimplyCastSync.Config;
using System.Data;

namespace SimplyCastSync.DataSource
{
    public class DbSrc : IDataSrc
    {
        public DataSrcType DsType { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public IQuery<DataSet> Ds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSrc(IQuery<DataSet> ds)
        {
            Ds = ds;
        }


    }
}
