using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimplyCastSync.PubLib.Log;

namespace SimplyCastSync.PubLib
{
    public class LogMgr
    {
        /// <summary>
        /// 
        /// </summary>
        private static Task _consolelogtask = null;

        /// <summary>
        /// 
        /// </summary>
        private static Task _filelogtask = null;

        /// <summary>
        /// 
        /// </summary>
        public static Task ConsoleLogTask
        {
            get
            {
                if (_consolelogtask == null) //&&
                {
                    _consolelogtask = LogExportAsync.ExportConsoleLogAsync();
                }
                return _consolelogtask;
            }
        }
        public static Task FileLogTask
        {
            get
            {
                if (_filelogtask == null) //&&
                {
                    _filelogtask = LogExportAsync.ExportFileLogAsync();
                }
                return _filelogtask;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExitConsoleLogTask()
        {
            AddExceptionLog(
                new ExceptionBody
                {
                    es = ExceptionSrc.Exit,
                    et = ExceptionType.Notification,
                    info = "Exiting Console's Logging Task",
                    ts = DateTime.Now
                }, LogType.Console_File);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ExitFileLogTask()
        {
            AddExceptionLog(
                new ExceptionBody
                {
                    es = ExceptionSrc.Exit,
                    et = ExceptionType.Notification,
                    info = "Exiting File's Logging Task",
                    ts = DateTime.Now
                }, LogType.Console_File);
        }
    }
}
