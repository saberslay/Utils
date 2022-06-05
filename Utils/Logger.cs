using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils{
    public class Logger {
        public static void LogError(String s) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
        }
        public static void LogInfo(String s) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
        }
        public static void ReedKey() {
            Console.ReadKey();
        }
    }
}
