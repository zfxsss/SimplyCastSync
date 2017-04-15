using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DataSource
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IDataSrc GetDs(string dsname);
    }
}
