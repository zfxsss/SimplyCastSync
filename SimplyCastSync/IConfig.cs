using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync
{
    interface IConfig<T>
    {
        T GetConfiguration(string configurationname);
    }
}
