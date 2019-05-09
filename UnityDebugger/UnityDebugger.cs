using System;
using BRM.DebugAdapter.Interfaces;
using UnityEngine;

namespace BRM.DebugAdapter
{
    public class UnityDebugger : IDebug
    {
        public bool Enabled { get; set; } = true;

        public void Log(string message)
        {
            if (!Enabled) return;
            Debug.Log(message);
        }

        public void LogError(string message)
        {
            if (!Enabled) return;
            Debug.LogError(message);
        }

        public void LogFormat(string message, params object[] args)
        {
            if (!Enabled) return;
            Debug.LogFormat(message, args);
        }

        public void LogWarningFormat(string message, params object[] args)
        {
            if (!Enabled) return;
            Debug.LogWarningFormat(message, args);
        }

        public void LogErrorFormat(string message, params object[] args)
        {
            if (!Enabled) return;
            Debug.LogErrorFormat(message, args);
        }

        public void LogWarning(string message)
        {
            if (!Enabled) return;
            Debug.LogWarning(message);
        }
        
        public void LogException(Exception e)
        {
            if (!Enabled) return;
            Debug.LogException(e);
        }
    }
}
