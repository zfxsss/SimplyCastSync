using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimplyCastSync.Config.ConfigRepository;
using SimplyCastSync.DBAccess;
using System.Data;
using SimplyCastSync.CompareEngine;
using static SimplyCastSync.CompareEngine.ComparerBuilder;

namespace SimplyCastSync.CompareEngine
{
    public class CompareEngine
    {
        public static void Run()
        {
            if (Content != null)
            {
                var pairsconfig = Content["pairs"];
                if ((pairsconfig != null) && pairsconfig.GetType() == typeof(JArray))
                {
                    var src = default(JObject);
                    var dest = default(JObject);

                    foreach (var pair in pairsconfig)
                    {
                        src = pair["source"] as JObject;
                        dest = pair["destination"] as JObject;

                        var cb = CB.GetComparer(src["ds"].ToString(), dest["ds"].ToString());
                        cb.Initialize();
                        cb.Mark();
                        cb.Commit();
                    }
                }
            }
            else
            {
                throw new Exception("Null Configuration");
            }

        }
    }
}
