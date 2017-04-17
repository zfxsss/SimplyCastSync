using System;
using System.Data;

namespace SimplyCastSync.DBAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlDataQuery : IQuery<DataSet>, IDisposable
    {
        private string _connstr;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetData(string querystr)
        {
            //Ds =  default(DataSet);
            return null;
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

        /// <summary>
        /// 
        /// </summary>
        public MysqlDataQuery(string connstr)
        {
            _connstr = connstr;
        }

    }
}
