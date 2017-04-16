using System;
using System.Data;

namespace SimplyCastSync.DBAccess
{

    public class FoxproDataQuery : IQuery<DataSet>, IDisposable
    {
        public DataSet Ds { get; private set; }

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

        /// <summary>
        /// 
        /// </summary>
        public FoxproDataQuery()
        {

        }

    }
}
