using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimplyCastSync.Config;
using SimplyCastSync.DBAccess;

namespace SimplyCastSync.DataSource
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataSrc : IConfig<KeyValuePair<string, string>[]>
    {
        IQuery Ds { get; }
    }
}
