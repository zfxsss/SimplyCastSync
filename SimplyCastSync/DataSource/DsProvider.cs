using SimplyCastSync.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DataSource
{
    public class DataSrcProvider : ConfigReader, IProvider
    {
        public static DataSrcProvider DsProvider { get; } = new DataSrcProvider();

        public IDataSrc GetDs(string dsname)
        {
            var configs = GetConfiguration(dsname);

            return null;
        }
    }
}
