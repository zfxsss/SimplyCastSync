using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System.Collections.Generic;
using System.Data;

namespace SimplyCastSync.DataSource
{
    public class DbSrc : IDataSrc<DataSet>
    {
        /// <summary>
        /// 
        /// </summary>
        public IQuery<DataSet> Q { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ConfigItems<KeyValuePair<string, string>> Config { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public DataSet Ds { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dr"></param>
        public void AddRd(DataRow dr)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dr"></param>
        public void UpdateRd(DataRow dr)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dr"></param>
        public void RemoveRd(DataRow dr)
        {

        }

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

            Ds = Q.GetData("");
        }


    }
}
