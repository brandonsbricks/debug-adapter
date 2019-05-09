using System.Collections.Generic;

namespace BRM.DebugAdapter.Models
{
    public class LogCollection
    {
        public List<LogData> Logs;
    }
    
    public class LogData
    {
        /// <summary>
        /// The message set in code and displayed on the console
        /// </summary>
        public string Message;
            
        /// <summary>
        /// Use this to train your eye on severity, significance.
        /// </summary>
        public string Severity;
            
        /// <summary>
        /// Add tags for search
        /// </summary>
        public List<string> Tags;
            
        /// <summary>
        /// Parsed stack trace
        /// </summary>
        public List<LineTrace> StackTrace;
    }
}