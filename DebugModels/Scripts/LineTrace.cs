using System;
using System.Text.RegularExpressions;

namespace BRM.DebugAdapter.Models
{
    /// <summary>
    /// represents a line in the stack trace string
    /// </summary>
    public class LineTrace
    {
        /// <summary>
        /// Parses incoming string associated values
        /// <paramref name="lineTrace"/> must be formatted as such when setting
        /// "at FullClassName.MethodName(MethodParams) in FileName :line LineNumber "
        /// </summary>
        public LineTrace(string lineTrace)
        {
            Trace = lineTrace;
        }
        /// <summary>
        /// Parses incoming string with regex and fills <paramref name="lineTrace"/> values
        /// string must formatted as such when setting
        /// "at FullClassName.MethodName(MethodParams) in FileName :line LineNumber "
        /// </summary>
        public string Trace
        {
            get { return _lineTrace; }
            set {
                if (!_lineRegex.IsMatch(value))
                {
                    throw new ArgumentException("Invalid format. See property comment for proper formatting");
                }

                _lineTrace = value;
                string[] values = _lineRegex.Split(value);
                FullClassName = values[0];
                MethodName = values[1];
                MethodParams = values[2] ?? "";
                FileName = values[3];
                LineNumber = values[4];
            }
        }
        
        private string _lineTrace;

        /// <summary>
        /// Includes Namespace
        /// </summary>
        public string FullClassName { get; private set; }
        public string MethodName { get; private set; }
        /// <summary>
        /// May be null
        /// </summary>
        public string MethodParams { get; private set; }
        public string FileName { get; private set; }
        public string LineNumber { get; private set; }
        
        private static Regex _lineRegex = new Regex(@"at (.+)\.(\w+)\((.*)\) in (.+)\s*\:line (\d+)", RegexOptions.CultureInvariant);
    }        
}
