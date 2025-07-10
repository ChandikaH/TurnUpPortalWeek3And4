using System;
using System.IO;

namespace TurnUpPortalWeek3And4.Utilities
{
    public class ReportManager
    {
        private static ReportManager _instance;
        private static readonly object _lock = new object();
        private string reportFilePath;

        private ReportManager()
        {
            reportFilePath = $"TestReport_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
        }

        public static ReportManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ReportManager();
                    return _instance;
                }
            }
        }

        public void CreateTest(string testName)
        {
            File.AppendAllText(reportFilePath, $"--- Test: {testName} ---{Environment.NewLine}");
        }

        public void Pass(string message) => WriteResult("PASS", message);
        public void Fail(string message) => WriteResult("FAIL", message);

        private void WriteResult(string result, string message)
        {
            var report = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{result}] {message}";
            File.AppendAllText(reportFilePath, report + Environment.NewLine);
        }
    }
}