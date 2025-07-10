using System;
using System.IO;

namespace TurnUpPortalWeek3And4.Utilities
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private readonly string logFilePath;

        private Logger()
        {
            logFilePath = $"TestLog_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
        }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Logger();
                    return _instance;
                }
            }
        }

        public void Info(string message) => WriteLog("INFO", message);
        public void Error(string message) => WriteLog("ERROR", message);

        private void WriteLog(string level, string message)
        {
            var logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
            Console.WriteLine(logMessage);
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }
    }
}