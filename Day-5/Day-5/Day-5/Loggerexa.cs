using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public delegate void LoggerDelegate();
    public delegate void Notify();
    public class Logger
    {
        public static void LogToFile()
        {
            Console.WriteLine("message will be logged to a file");
        }
        public static void LogToConsole()
        {
            Console.WriteLine("message will be logged to a ConsoleWindow");
        }
    }

    public class Notificaton
    {
        public static void Message1()
        {
            Console.WriteLine("message 1");
        }
        public static void Message2()
        {
            Console.WriteLine("message 2");
        }
        public static void Message3()
        {
            Console.WriteLine("message 3");
        }

    }
    internal class Loggerexa
    {
        public static void Main2()
        {
            //LoggerDelegate logger = Logger.LogToFile;
            //logger += Logger.LogToConsole;

            //logger();
            Notify notify = Notificaton.Message1;
            notify += Notificaton.Message2;
            notify += Notificaton.Message3;
            notify -= Notificaton.Message3;
            notify();
        }
    }
}
