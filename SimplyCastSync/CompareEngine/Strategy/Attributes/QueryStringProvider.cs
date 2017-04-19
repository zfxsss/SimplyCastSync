using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine.Strategy.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    class QueryStringProvider : Attribute
    {
        public QueryStringProvider(string providername)
        {
            ProviderName = providername;
        }
        public string ProviderName { get; set; }
    }
}
