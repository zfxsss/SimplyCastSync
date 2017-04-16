﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.DataSource
{
    /// <summary>
    /// 
    /// </summary>
    public class RdEquatable : IEquatable<JToken>
    {
        /// <summary>
        /// 
        /// </summary>
        private JToken self;

        /// <summary>
        /// 
        /// </summary>
        private KeyValuePair<string, string[]>[] fields;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Equals(JToken t)
        {
            if (self == t)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="kvps"></param>
        public RdEquatable(JToken t, KeyValuePair<string, string[]>[] kvps)
        {
            self = t;
            fields = kvps;
        }

    }
}