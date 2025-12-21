using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameLibraryManager.Utilities
{
    // Singleton Logger Class
    public sealed class AppLogger
    {
        private static AppLogger instance;
        private static readonly object lockObj = new();
        private const string LogFile = "actions.log";

        private AppLogger() { }

        // Singleton instance property
        public static AppLogger Instance
        {
            get
            {
                lock (lockObj)
                {
                    return instance ??= new AppLogger();
                }
            }
        }

        // Log method to append messages to the log file
        public void Log(string message)
        {
            File.AppendAllText(
                LogFile,
                $"{DateTime.Now} : {message}{Environment.NewLine}");
        }
    }
}
