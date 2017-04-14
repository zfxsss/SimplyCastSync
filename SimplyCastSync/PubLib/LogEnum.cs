﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.PubLib
{
    /// <summary>
    /// 异常类型
    /// </summary>
    public enum ExceptionType
    {
        Error = 0,
        Warning,
        Notification,
        Message
    }

    /// <summary>
    /// log type
    /// </summary>
    public enum LogType
    {
        Console = 0, //console
        File, //file
        Console_File //console & file
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ExceptionSrc
    {
        Init = 0,
        Processing,
        Cleanup,
        Exit
    }
}
