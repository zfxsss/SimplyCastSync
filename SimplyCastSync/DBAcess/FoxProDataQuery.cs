using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SimplyCastSync.DBAccess
{

    public class FoxProDataQuery : IQuery<DataSet>
    {
        private  DataSet  ds;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetData()
        {
            return default(DataSet);
        }

    }
}
