using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SimplyCastSync.DBAccess
{
    public class SimplyCastWebApiQuery : IQuery<JObject>, IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        private string queryaddress = "";

        private string updateaddress = "";
        /// <summary>
        /// 
        /// </summary>
        private string key = "";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        private void AddMetaData(HttpClient client, string optype)
        {
            if (optype == "query")
            {
                client.BaseAddress = new Uri(queryaddress);
            }
            else if (optype == "update")
            {
                client.BaseAddress = new Uri(updateaddress);
            }

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + key);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public JObject GetData(string querystr)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    AddMetaData(client, "query");
                    var gettask = client.GetAsync(querystr);
                    gettask.Wait(TimeSpan.FromSeconds(15));
                    if (gettask.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var readtask = gettask.Result.Content.ReadAsStringAsync();
                        readtask.Wait();
                        return JObject.Parse(readtask.Result);
                    }
                    else
                    {
                        return JObject.Parse(File.ReadAllText(@"\\JsonTemplate\\simplycast_emptycontacts.json"));
                    }
                }
                catch (Exception ex)
                {
                    // add log

                    return null;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="extras"></param>
        /// <returns></returns>
        public int UpdateData(JObject ds, params string[] extras)
        {
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public SimplyCastWebApiQuery(string connstr)
        {
            var info = connstr.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string pubkey = "", secretkey = "";
            foreach (var configitem in info)
            {
                if (configitem.Split('=')[0] == "QueryAddress")
                {
                    queryaddress = configitem.Split('=')[1];
                }
                else if (configitem.Split('=')[0] == "UpdateAddress")
                {
                    updateaddress = configitem.Split('=')[1];
                }
                else if (configitem.Split('=')[0] == "PublicKey")
                {
                    pubkey = configitem.Split('=')[1];
                }
                else if (configitem.Split('=')[0] == "SecretKey")
                {
                    secretkey = configitem.Split('=')[1];
                }
            }

            key = Convert.ToBase64String(Encoding.ASCII.GetBytes(pubkey + ":" + secretkey));
        }
    }
}
