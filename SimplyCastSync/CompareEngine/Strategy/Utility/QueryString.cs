using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine.Strategy.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryString
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="providername"></param>
        /// <param name="paramsarray"></param>
        /// <returns></returns>
        public static string GetQueryString(string providername, object[] paramsarray)
        {
            if (providername == "CommonRegex")
            {
                return null;
            }
            else
                throw new Exception("");

        }
    }
}
