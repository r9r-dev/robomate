using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robo.Engine
{
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Event = 1,
        Warning = 2,
        Error = 4,
        All = Event | Warning | Error
    }
}
