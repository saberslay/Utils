using System;
using System.Threading;

namespace Utils{
    public class Logger {
        public static void LogError(String s) {
            Thread LogErrorthread = new Thread(new ThreadStart(() => {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{s}");
            }));
            LogErrorthread.Start();
        }
        public static void LogWanning(String s) {
            Thread LogWanningthread = new Thread(new ThreadStart(() => {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{s}");
            }));
            LogWanningthread.Start();
        }
        public static void LogInfo(String s) {
            Thread LogInfothread = new Thread(new ThreadStart(() => {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{s}");
            }));
            LogInfothread.Start();
        }
        public static void ReedKey() {
            Console.ReadKey();
        }
    }
}
