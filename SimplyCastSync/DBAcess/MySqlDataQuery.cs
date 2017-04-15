using System;
using System.Data;

namespace SimplyCastSync.DBAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlDataQuery : IQuery<DataSet>, IDisposable
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetData(string querystr)
        {
            return default(DataSet);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public int UpdateData(DataSet ds)
        {
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {

        }

    }
}
