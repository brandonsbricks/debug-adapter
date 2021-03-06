﻿using System;
using BRM.DebugAdapter.Interfaces;

namespace BRM.DebugAdapter
{
    /// <summary>
    /// Wrapper for Console.WriteLine with configurable, prepended strings for log severity
    /// </summary>
    public sealed class ConsoleDebugger : IDebug
    {
        public bool Enabled { get; set; } = true;
        
        public string LogPreString = "";
        public string WarningPreString = "~";
        public string ErrorPreString = "!";
        public string ExceptionPreString = "(>_<)";
        
        public void Log(string message)
        {
            if (!Enabled) return;
            Console.WriteLine($"{LogPreString}{message}");
        }
        
        public void LogWarning(string message)
        {
            if (!Enabled) return;
            Console.WriteLine($"{WarningPreString}{message}");
        }

        public void LogError(string message)
        {
            if (!Enabled) return;
            Console.WriteLine($"{ErrorPreString}{message}");
        }

        public void LogFormat(string message, params object[] args)
        {
            if (!Enabled) return;
            Console.WriteLine($"{LogPreString}{message}", args);
        }
        
        public void LogWarningFormat(string message, params object[] args)
        {
            if (!Enabled) return;
            Console.WriteLine($"{WarningPreString}{string.Format(message, args)}");
        }

        public void LogErrorFormat(string message, params object[] args)
        {
            if (!Enabled) return;
            Console.WriteLine($"{ErrorPreString}{string.Format(message, args)}");
        }

        public void LogException(Exception e)
        {
            if (!Enabled) return;
            Console.WriteLine($"{ExceptionPreString}{e.Message}");
        }
    }
}
