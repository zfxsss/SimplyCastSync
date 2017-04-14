using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DBAccess
{
    using System.Data;
    public interface IQuery
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DataSet GetDataSet();

        /// <summary>
        /// 
        /// </summary>
        void CommitDataSet();
    }
}
