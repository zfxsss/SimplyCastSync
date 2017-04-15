using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;


namespace SimplyCastSync.DBAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class MySqlDataQuery : IQuery<DataSet>
    {
        public MySqlConnection DBConnection { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetData()
        {
            return default(DataSet);
        }

    }
}
