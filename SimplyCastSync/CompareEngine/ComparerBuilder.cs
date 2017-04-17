using Newtonsoft.Json.Linq;
using SimplyCastSync.DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimplyCastSync.Config.ConfigRepository;

namespace SimplyCastSync.CompareEngine
{
    public class ComparerBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        public static ComparerBuilder CB { get; } = new ComparerBuilder();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="srcdsname"></param>
        /// <param name="destdsname"></param>
        /// <returns></returns>
        public IComparer GetComparer(string srcdsname, string destdsname)
        {
            var src_ds_config = Content["datasource"].Where(x => x["name"].ToString() == srcdsname).First();
            var dest_ds_config = Content["datasource"].Where(x => x["name"].ToString() == destdsname).First();
            //D => D
            if ((src_ds_config["dstype"].ToString() == "DataSet") && (dest_ds_config["dstype"].ToString() == "DataSet"))
            {
                IQuery<DataSet> q_src = QueryProvider.DsProvider.GetQuery<DataSet>(src_ds_config["queryname"].ToString(), src_ds_config["connstr"].ToString());
                IQuery<DataSet> q_dest = QueryProvider.DsProvider.GetQuery<DataSet>(dest_ds_config["queryname"].ToString(), dest_ds_config["connstr"].ToString());
                return new JsonComparer<DataSet, DataSet>(q_src, q_dest);
            }
            //D => J
            else if ((src_ds_config["dstype"].ToString() == "DataSet") && (dest_ds_config["dstype"].ToString() == "JObject"))
            {
                IQuery<DataSet> q_src = QueryProvider.DsProvider.GetQuery<DataSet>(src_ds_config["queryname"].ToString(), src_ds_config["connstr"].ToString());
                IQuery<JObject> q_dest = QueryProvider.DsProvider.GetQuery<JObject>(dest_ds_config["queryname"].ToString(), dest_ds_config["connstr"].ToString());
                return new JsonComparer<DataSet, JObject>(q_src, q_dest);
            }
            //J => J
            else if ((src_ds_config["dstype"].ToString() == "JObject") && (dest_ds_config["dstype"].ToString() == "JObject"))
            {
                IQuery<JObject> q_src = QueryProvider.DsProvider.GetQuery<JObject>(src_ds_config["queryname"].ToString(), src_ds_config["connstr"].ToString());
                IQuery<JObject> q_dest = QueryProvider.DsProvider.GetQuery<JObject>(dest_ds_config["queryname"].ToString(), dest_ds_config["connstr"].ToString());
                return new JsonComparer<JObject, JObject>(q_src, q_dest);
            }
            //J => D
            else if ((src_ds_config["dstype"].ToString() == "JObject") && (dest_ds_config["dstype"].ToString() == "DataSet"))
            {
                IQuery<JObject> q_src = QueryProvider.DsProvider.GetQuery<JObject>(src_ds_config["queryname"].ToString(), src_ds_config["connstr"].ToString());
                IQuery<DataSet> q_dest = QueryProvider.DsProvider.GetQuery<DataSet>(dest_ds_config["queryname"].ToString(), dest_ds_config["connstr"].ToString());
                return new JsonComparer<JObject, DataSet>(q_src, q_dest);
            }
            else
                throw new Exception("");
        }

        /// <summary>
        /// 
        /// </summary>
        private ComparerBuilder()
        {

        }
    }
}
