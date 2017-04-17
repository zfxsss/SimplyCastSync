using static SimplyCastSync.Config.ConfigRepository;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DBAccess
{
    public class QueryProvider : IProvider
    {
        public static QueryProvider DsProvider { get; } = new QueryProvider();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dsname"></param>
        /// <returns></returns>
        public IQuery<T> GetQuery<T>(string queryname, string connstr)
        {
            if (queryname == "FoxproData")
            {
                return new FoxproDataQuery() as IQuery<T>;
            }
            else if (queryname == "MysqlData")
            {
                return new MysqlDataQuery() as IQuery<T>;
            }
            else if (queryname == "SimplyCastWebApi")
            {
                return new SimplyCastWebApiQuery() as IQuery<T>;
            }
            else
                throw new Exception("");

        }

        /// <summary>
        /// 
        /// </summary>
        private QueryProvider()
        {

        }
    }
}
