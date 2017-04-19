using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine.Strategy
{
    public class StrategySyncProvider<S, D>
    {
        /// <summary>
        /// 
        /// </summary>
        public static StrategySyncProvider<S, D> SSP = new StrategySyncProvider<S, D>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strategyname"></param>
        /// <returns></returns>
        public Action<IComparerT<S, D>> GetStrategySync(string strategyname)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        private StrategySyncProvider()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        private Action<IComparerT<S, D>> SimplyCastAPIStrategy = comparer =>
        {


        };


    }
}
