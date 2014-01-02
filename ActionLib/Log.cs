using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionLib
{
    static public class Log
    {
        public delegate void OnLogChangeEvent(String LogMsg);
        static public event OnLogChangeEvent LogEventHandler = null;

        static public void WriteLine(String Msg)
        {
            if (LogEventHandler != null)
            {
                LogEventHandler(Msg);
            }
        }
    }
}
