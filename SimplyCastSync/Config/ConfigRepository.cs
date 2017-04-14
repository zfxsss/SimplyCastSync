using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace SimplyCastSync.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigRepository
    {
        private static JObject _content = null;
        /// <summary>
        /// 
        /// </summary>
        public static JObject Content
        {
            get
            {
                try
                {
                    if (_content == null)
                    {
                        _content = JObject.Parse(File.ReadAllText("process_config.json"));
                    }
                    return _content;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }
    }
}
