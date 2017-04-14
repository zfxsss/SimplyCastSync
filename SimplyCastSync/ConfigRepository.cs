using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync
{
    using System.IO;
    using Newtonsoft.Json.Linq;
    
    /// <summary>
    /// 
    /// </summary>
    public class ConfigRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public static JObject Content { get; } = JObject.Parse(File.ReadAllText(""));
    }
}
