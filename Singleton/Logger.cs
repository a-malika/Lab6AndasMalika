using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public enum LogLevel
    {
        INFO, WARNING, ERROR
    }
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _instanceLock = new object();
        private LogLevel _level;
        private string filePath = "C:/Users/malik/OneDrive/Рабочий стол/test_lab.txt.txt";
        private Logger()
        {
            Console.WriteLine("Экземпляр создан");
        }
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
        }
        public void Log(string message, LogLevel level)
        {
            if (_level == null || _level <= level)
            {
                lock (_instanceLock)
                {
                    File.AppendAllText(filePath, $"{level}: {message}\n");
                }
            }
            else
            {
                lock (_instanceLock)
                {
                    File.AppendAllText(filePath, $"{_level}: {message}\n");
                }
            }
        }
        public void SetLogLevel(LogLevel level)
        {
            _level = level;
        }
        public void SetLogFilePath(string path)
        {
            filePath = path;
        }
        public void ReadLogs()
        {
            lock (_instanceLock)
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}
