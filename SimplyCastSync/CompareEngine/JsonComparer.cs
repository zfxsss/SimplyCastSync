using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimplyCastSync.CompareEngine.Strategy;
using SimplyCastSync.CompareEngine.Strategy.Attributes;
using SimplyCastSync.CompareEngine.Strategy.Utility;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine
{
    /// <summary>
    /// 
    /// </summary>
    [QueryStringProvider("CommonRegex")]
    public class JsonComparer<S, D> : IComparerT<S, D>
    {
        /// <summary>
        /// 
        /// </summary>
        private IQuery<S> sourceq;

        /// <summary>
        /// 
        /// </summary>
        private IQuery<D> destinationq;

        /// <summary>
        /// 
        /// </summary>
        public S Source { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public D Destination { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public JObject Config { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Action<IComparerT<S, D>> StrategySync { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public JsonComparer(IQuery<S> srcq, IQuery<D> destq, JObject config)
        {
            sourceq = srcq;
            destinationq = destq;

            Config = config;

            if (!string.IsNullOrWhiteSpace(Config["syncstrategy"].ToString()))
            {
                StrategySync = StrategySyncProvider<S, D>.SSP.GetStrategySync(Config["syncstrategy"].ToString());
            }
            else
            {
                StrategySync = StrategySyncProvider<S, D>.SSP.GetStrategySync("");
            }

            TypeCheck();
        }

        /// <summary>
        /// 
        /// </summary>
        private void TypeCheck()
        {
            // source
            if (typeof(S) == typeof(DataSet))
            {
                //jsource = JObject.Parse(JsonConvert.SerializeObject(source));
                //add log here

            }
            else if (typeof(S) == typeof(JObject))
            {
                //add log here

            }
            else
            {
                //add log and throw exception
                throw new Exception("Unsupported Source Type");
            }

            // destination
            if (typeof(D) == typeof(DataSet))
            {
                //jsource = JObject.Parse(JsonConvert.SerializeObject(source));
                //add log here

            }
            else if (typeof(D) == typeof(JObject))
            {
                //add log here
            }
            else
            {
                //add log and throw exception
                throw new Exception("Unsupported Source Type");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void InitializeS(params object[] sp)
        {
            if (sp != null && sp.Length > 0)
            {
                //add handler
            }
            else
            {
                Source = sourceq.GetData(Config["source"]["querystring"].ToString());
            }

            if (Source == null)
            {
                //add log and throw exception

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dp"></param>
        public void InitializeD(params object[] dp)
        {
            string querystr = "";
            if (dp != null && dp.Length > 0)
            {
                var attrs = this.GetType().GetCustomAttributes(typeof(QueryStringProvider), false);
                if (attrs != null && attrs.Length > 0)
                {
                    querystr = QueryString.GetQueryString(((QueryStringProvider)attrs[0]).ProviderName, dp);
                    Destination = destinationq.GetData(querystr);
                }
                else
                {
                    //throw error

                }

            }
            else
            {
                //no params
                Destination = destinationq.GetData("");
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mp"></param>
        public void Mark(params object[] mp)
        {
            if (mp != null && mp.Length > 0)
            {
                if (typeof(D) == typeof(DataSet))
                {

                }
                else if (typeof(D) == typeof(JObject))
                {
                    var token_existing = (Destination as JObject).SelectToken("");
                    if (token_existing != null)
                    {
                        var token_equal = (Destination as JObject).SelectToken("");
                        if (token_equal != null)
                        {
                            //Destination operation

                        }
                    }
                    else
                    {
                        //Destination operation

                    }

                }
            }
            else
            {
                if (typeof(D) == typeof(DataSet))
                {
                    if (typeof(S) == typeof(DataSet))
                    {

                    }
                    else if (typeof(S) == typeof(JObject))
                    {

                    }
                }
                else if (typeof(D) == typeof(JObject))
                {
                    if (typeof(S) == typeof(DataSet))
                    {

                    }
                    else if (typeof(S) == typeof(JObject))
                    {

                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {
            destinationq.UpdateData(Destination);

            #region temperory
            //if (typeof(D) == typeof(JObject))
            //{
            //    destinationq.UpdateData(Destination);
            //}
            //else if (typeof(D) == typeof(DataSet))
            //{
            //    destinationq.UpdateData(Destination);
            //}
            #endregion
        }


    }
}
