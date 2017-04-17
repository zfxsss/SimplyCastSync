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
        #region useful?
        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeInsertedRds_Src { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeDeletedRds_Src { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeUpdatedRds_Src { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeInsertedRds_Dest { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeDeletedRds_Dest { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeUpdatedRds_Dest { get; private set; } = new List<long>();

        #endregion
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
        private JObject jsource;

        /// <summary>
        /// 
        /// </summary>
        private JObject jdestination;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public JsonComparer(IQuery<S> src, IQuery<D> dest)
        {
            sourceq = src;
            destinationq = dest;

            source = sourceq.GetData("");
            destination = destinationq.GetData("");

            if (typeof(S) == typeof(DataSet))
            {
                jsource = JObject.Parse(JsonConvert.SerializeObject(source));
            }
            else if (typeof(S) == typeof(JArray))
            {

            }
            else
            {
                throw new Exception("Unsupported Source Type");
            }

            if (typeof(D) == typeof(DataSet))
            {
                jdestination = JObject.Parse(JsonConvert.SerializeObject(destination));
            }
            else if (typeof(S) == typeof(JArray))
            {

            }
            else
            {
                throw new Exception("Unsupported Source Type");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            if ((jsource == null) || (jdestination == null))
            {
                throw new Exception("");
            }

            if (jdestination.GetType() == typeof(JArray))
            {
                //Destination = (JArray)JDestination;
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

        }

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {

        }
    }
}
