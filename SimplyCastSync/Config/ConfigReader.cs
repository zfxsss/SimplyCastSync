using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimplyCastSync.Config.ConfigRepository;

namespace SimplyCastSync.Config
{

    /// <summary>
    /// 
    /// </summary>
    public class ConfigReader : IConfig<KeyValuePair<string, string>[]>
    {
        /// <summary>
        /// 
        /// </summary>
        public KeyValuePair<string, string>[] ConfigInfo { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configname"></param>
        /// <returns></returns>
        public KeyValuePair<string, string>[] GetConfiguration(string configname)
        {
            //Content;
            ConfigInfo = null;
            return ConfigInfo;
        }
    }
}
