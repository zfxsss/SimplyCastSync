using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonComparer<S, D> : IComparer
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
        private S source;

        /// <summary>
        /// 
        /// </summary>
        private D destination;

        /// <summary>
        /// 
        /// </summary>
        private JObject sourceconfig;

        /// <summary>
        /// 
        /// </summary>
        private JObject destinationconfig;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public JsonComparer(IQuery<S> srcq, IQuery<D> destq, JObject srcconfig, JObject destconfig)
        {
            sourceq = srcq;
            destinationq = destq;

            sourceconfig = srcconfig;
            destinationconfig = destconfig;

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
        public void Initialize()
        {
            source = sourceq.GetData("");
            destination = destinationq.GetData("");

            if ((source == null) || (destination == null))
            {
                //add log and throw exception


            }

            //foreach (JObject item in jdestination)
            //{
            //    item.Add("rds", new JValue(""));
            //    item["rds"] = DataSrcType.Foxpro.ToString();
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        public void Mark()
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
                destinationq.UpdateData(destination);
            }
            else if (typeof(D) == typeof(DataSet))
            {
                destinationq.UpdateData(destination);
            }
        }


    }
}
