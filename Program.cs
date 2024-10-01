using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.SetLogLevel(LogLevel.INFO);
            logger.SetLogFilePath("C:/Users/malik/OneDrive/Рабочий стол/test_lab.txt.txt");

            Thread thread1 = new Thread(() => LogMessages(LogLevel.INFO));
            Thread thread2 = new Thread(() => LogMessages(LogLevel.ERROR));
            Thread thread3 = new Thread(() => LogMessages(LogLevel.WARNING));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            logger.ReadLogs();
        }
        public static void LogMessages(LogLevel level)
        {
            Logger logger = Logger.Instance;
            for (int i = 0; i < 5; i++)
            {
                logger.Log($"Message {i} from thread {Thread.CurrentThread.ManagedThreadId}", level);
            }
        }
    }
}
