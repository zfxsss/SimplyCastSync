using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimplyCastSync.PubLib.Log;

namespace SimplyCastSync.PubLib
{
    /// <summary>
    /// 
    /// </summary>
    internal class LogExportAsync
    {
        /// <summary>
        /// 
        /// </summary>
        internal static Task ExportConsoleLogAsync()
        {
            return Task.Run(() => ExportConsoleLog());
        }

        /// <summary>
        /// 
        /// </summary>
        internal static Task ExportFileLogAsync()
        {
            return Task.Run(() => ExportFileLog());
        }
    }
}
