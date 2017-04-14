using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync
{
    using static ConfigRepository;
    /// <summary>
    /// 
    /// </summary>
    class FieldsReader : IConfig<string[]>
    {
        /// <summary>
        /// 
        /// </summary>
        public string[] ConfigInfo
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configname"></param>
        /// <returns></returns>
        public string[] GetConfiguration(string configname)
        {
            //Content.
            ConfigInfo = null;
            return ConfigInfo;
        }
    }
}
