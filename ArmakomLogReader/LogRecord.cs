using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArmakomLogReader
{
    public class LogRecord
    {
        public enum FieldIndex
        {
            //${longdate};${logger};${level};${message};${exception};${callsite}"
            LogTime   = 0,
            Logger    = 1,   
            Level     = 2,    
            Message   = 3,  
            Exception = 4,            
            CallSite  = 5
        }        

        public LogRecord()
        {
        }

        public DateTime LogTime    { get; set; }
        public String   Level      { get; set; }
        public String   Message    { get; set; }
        public String   Exception  { get; set; }
        public String   Logger     { get; set; }
        public String   CallSite   { get; set; }
    }
}
