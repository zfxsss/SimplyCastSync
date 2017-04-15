using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;
using System.Collections.Generic;
using System.Data;

namespace SimplyCastSync.DataSource
{
    public class FoxproDbSrc : IDataSrc<DataSet>
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
        public FoxproDbSrc()
        {
            Q = new FoxproDataQuery();
        }


    }
}
