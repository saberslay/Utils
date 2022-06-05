using System;

namespace Utils{
    public class Logger {
        public static void LogError(String s) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{0}] {1}", DateTime.Now, s);
        }
        public static void LogWanning(String s) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{0}] {1}",DateTime.Now,s);
        }
        public static void LogInfo(String s) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[{0}] {1}", DateTime.Now, s);
        }
        public static void ReedKey() {
            Console.ReadKey();
        }
    }
}
