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
        
        /// <summary>
        /// disables logging on the local instance associated with this function 
        /// </summary>
        bool Enabled { get; set; }
    }
}
