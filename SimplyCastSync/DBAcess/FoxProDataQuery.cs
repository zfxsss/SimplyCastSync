using System;
using System.Data;

namespace SimplyCastSync.DBAccess
{
    public class FoxproDataQuery : IQuery<DataSet>, IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetData(string querystr)
        {
            //Ds = default(DataSet);
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
        public FoxproDataQuery()
        {

        }

    }
}
