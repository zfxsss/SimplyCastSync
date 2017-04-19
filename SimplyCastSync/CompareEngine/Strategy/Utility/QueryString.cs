using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine.Strategy.Utility
{
    public class QueryString
    {
        public static string GetQueryString(string providername, object[] paramsarray)
        {
            if (providername == "SimplyCastQuery")
            {
                return null;
            }
            else
                throw new Exception("");

        }
    }
}
