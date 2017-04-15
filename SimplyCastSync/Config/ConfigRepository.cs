using System;
using System.IO;
using Newtonsoft.Json.Linq;

using static SimplyCastSync.PubLib.Log;

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
                    AddExceptionLog(new PubLib.ExceptionBody { }, PubLib.LogType.Console_File);
                    return null;
                }
            }

        }
    }
}
