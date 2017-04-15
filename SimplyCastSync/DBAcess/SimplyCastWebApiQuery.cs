using Newtonsoft.Json.Linq;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DBAcess
{
    public class SimplyCastWebApiQuery : IQuery<JArray>
    {

        public JArray GetData()
        {
            return default(JArray);
        }
    }
}
