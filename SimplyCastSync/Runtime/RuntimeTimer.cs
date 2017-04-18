using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimplyCastSync.Config.ConfigRepository;

namespace SimplyCastSync.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    public class RuntimeTimer
    {
        private static RuntimeTimer rtt;

        public static RuntimeTimer RTT
        {
            get
            {
                if (rtt == null)
                {
                    rtt = new RuntimeTimer();
                }
                return rtt;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private DateTime lastexecution;

        /// <summary>
        /// 
        /// </summary>
        private DateTime nextexecution;

        /// <summary>
        /// 
        /// </summary>
        private TimeSpan timespan;

        private RuntimeTimer()
        {
            lastexecution = DateTime.Now;
            nextexecution = DateTime.Now;
            int interval = Content["running"].Value<int>("interval");

            //minimum interval == 60 secs
            if (interval < 60)
            {
                timespan = new TimeSpan(0, 0, 60);
            }
            else
            {
                timespan = new TimeSpan(0, 0, interval);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Timeout()
        {
            DateTime tempdt = DateTime.Now;
            if (tempdt > nextexecution)
            {
                lastexecution = tempdt;
                while (tempdt > nextexecution)
                {
                    //may introduce better algorithm
                    nextexecution += timespan;
                }

                return true;
            }
            return false;
        }
    }
}
