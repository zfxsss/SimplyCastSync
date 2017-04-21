using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimplyCastSync.CompareEngine.Strategy.Attributes;

namespace SimplyCastSync.CompareEngine.Strategy
{
    public class StrategySyncProvider<S, D>
    {
        /// <summary>
        /// 
        /// </summary>
        public static StrategySyncProvider<S, D> SSP = new StrategySyncProvider<S, D>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strategyname"></param>
        /// <returns></returns>
        public Action<IComparerT<S, D>> GetStrategySync(string strategyname)
        {
            if (string.IsNullOrEmpty(strategyname))
            {
                return DefaultStrategy;
            }
            else if (strategyname == "DataSetToSimplyCastAPI")
            {
                return DataSetToSimplyCastAPIStrategy;
            }
            else
                throw new Exception("");
        }

        /// <summary>
        /// 
        /// </summary>
        private StrategySyncProvider()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private Action<IComparerT<S, D>> DataSetToSimplyCastAPIStrategy = comparer =>
        {
            if (comparer.GetType() == typeof(JsonComparer<S, D>))
            {
                //var attrs = comparer.GetType().GetCustomAttributes(typeof(QueryStringProvider), false);
                //if (attrs != null && attrs.Length > 0)
                //{
                //    ((QueryStringProvider)attrs[0]).ProviderName = "SimplyCastQuery";
                //}

                //may introduce different strategies
                comparer.InitializeS("none");

                if (typeof(S) == typeof(DataSet))
                {
                    var src = JsonConvert.SerializeObject(comparer.Source as DataSet, Formatting.Indented);
                    var jsrc = JObject.Parse(src);
                    foreach (var srd in jsrc.First.Values())
                    {
                        var initparams = new List<JToken>();
                        foreach (var param in comparer.Config["source"]["keyfields"])
                        {
                            initparams.Add(new JProperty(param.Value<string>(), srd[param.Value<string>()]));
                        }

                        comparer.InitializeD("none", initparams.ToArray());
                        comparer.Mark(new JToken[] { srd });
                    }
                }

            }
        };

        /// <summary>
        /// 
        /// </summary>
        private Action<IComparerT<S, D>> DefaultStrategy = comparer =>
        {


        };


    }
}
