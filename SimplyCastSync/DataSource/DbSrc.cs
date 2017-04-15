using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System.Collections.Generic;
using System.Data;

namespace SimplyCastSync.DataSource
{
    public class DbSrc : IDataSrc<DataSet>
    {
        public IQuery<DataSet> Q { get; private set; }

        public ConfigItems<KeyValuePair<string, string>> Config { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            //Ds.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSrc(IQuery<DataSet> q, ConfigItems<KeyValuePair<string, string>> config)
        {
            //Q = new FoxproDataQuery();
            Q = q;
            Config = config;
        }


    }
}
