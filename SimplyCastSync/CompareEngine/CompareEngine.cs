﻿using Newtonsoft.Json.Linq;
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
using SimplyCastSync.CompareEngine.Strategy;

namespace SimplyCastSync.CompareEngine
{
    public class CompareEngine
    {
        /// <summary>
        ///
        /// </summary>
        public static Action Sync = () =>
        {
            if (Content != null)
            {
                var pairsconfig = Content["pairs"];
                if ((pairsconfig != null) && pairsconfig.GetType() == typeof(JArray))
                {
                    var src = default(JObject);
                    var dest = default(JObject);
                    string syncstrategy = "";
                    foreach (var pair in pairsconfig)
                    {
                        src = pair["source"] as JObject;
                        dest = pair["destination"] as JObject;
                        syncstrategy = pair["syncstrategy"].ToString();
                        // D => J
                        if ((src["dstype"].ToString() == "DataSet") && (dest["dstype"].ToString() == "JObject"))
                        {
                            var comparer = CB.GetComparer<DataSet, JObject>(src, dest, syncstrategy);
                            comparer.StrategySync(comparer);
                        }
                        // D => D
                        else if ((src["dstype"].ToString() == "DataSet") && (dest["dstype"].ToString() == "DataSet"))
                        {
                            var comparer = CB.GetComparer<DataSet, DataSet>(src, dest, syncstrategy);
                            comparer.StrategySync(comparer);
                        }
                        // J => J
                        else if ((src["dstype"].ToString() == "JObject") && (dest["dstype"].ToString() == "JObject"))
                        {
                            var comparer = CB.GetComparer<JObject, JObject>(src, dest, syncstrategy);
                            comparer.StrategySync(comparer);
                        }
                        // J => D
                        else if ((src["dstype"].ToString() == "JObject") && (dest["dstype"].ToString() == "DataSet"))
                        {
                            var comparer = CB.GetComparer<JObject, DataSet>(src, dest, syncstrategy);
                            comparer.StrategySync(comparer);
                        }
                        // not supported
                        else
                            throw new Exception("");

                    }
                }
            }
            else
            {
                throw new Exception("Null Configuration");
            }

        };
    }
}
