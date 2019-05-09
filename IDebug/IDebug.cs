using System;

namespace BRM.DebugAdapter.Interfaces
{
    /// <summary>
    /// Supports Common Log Types
    /// </summary>
    public interface IDebug
    {
        void Log(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogFormat(string message, params object[] args);
        void LogWarningFormat(string message, params object[] args);
        void LogErrorFormat(string message, params object[] args);
        
        void LogException(Exception e);
        bool Enabled { get; set; }
    }
    public static class HexColors
    {
        public const string Red = "#FF0000";
        public const string Orange = "#FFA500";
        public const string Yellow = "#FFFF00";
        public const string Green = "#008000";
        public const string Blue = "#0000FF";
        public const string Indigo = "#4B0082";
        public const string Violet = "#EE82EE";

        public const string Grey = "#808080";
        public const string Brown = "#A52A2A";
    }
}
