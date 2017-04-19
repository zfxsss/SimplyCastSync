using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimplyCastSync.CompareEngine.Strategy;
using SimplyCastSync.CompareEngine.Strategy.Attributes;
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
    [QueryStringProvider("Not Defined")]
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
        public JObject SourceConfig { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public JObject DestinationConfig { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Action<IComparerT<S, D>> StrategySync { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public JsonComparer(IQuery<S> srcq, IQuery<D> destq, JObject srcconfig, JObject destconfig, string syncstrategy)
        {
            sourceq = srcq;
            destinationq = destq;

            SourceConfig = srcconfig;
            DestinationConfig = destconfig;

            if (!string.IsNullOrWhiteSpace(syncstrategy))
            {
                StrategySync = StrategySyncProvider<S, D>.SSP.GetStrategySync(syncstrategy);
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

            }
            else
            {
                Source = sourceq.GetData(SourceConfig["querystring"].ToString());
            }

            if (Source == null)
            {
                //add log and throw exception

            }

            #region not used
            //foreach (JObject item in jdestination)
            //{
            //    item.Add("rds", new JValue(""));
            //    item["rds"] = DataSrcType.Foxpro.ToString();
            //}
            #endregion
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
                //Type t = this.GetType();
                //var o = t.GetCustomAttributes(typeof(QueryStringProvider), false);

            }
            else
            {

            }

            Destination = destinationq.GetData(querystr);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Mark(params object[] mp)
        {
            if (typeof(D) == typeof(DataSet))
            {

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

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {
            if (typeof(D) == typeof(JObject))
            {
                destinationq.UpdateData(Destination);
            }
            else if (typeof(D) == typeof(DataSet))
            {
                destinationq.UpdateData(Destination);
            }
        }


    }
}
