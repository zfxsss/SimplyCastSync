﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DBAccess
{
    using System.Data;
    public class FoxProDataQuery : IQuery
    {
        private DataSet _ds;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CommitDataSet()
        {

        }
    }
}
