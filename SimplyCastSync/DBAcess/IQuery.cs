using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DBAccess
{
    using System.Data;
    public interface IQuery<T>
    {
        /// <summary>
        /// 
        /// </summary>k
        /// <returns></returns>
        T GetData();

    }
}
