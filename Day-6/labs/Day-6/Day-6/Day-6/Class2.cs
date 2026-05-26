using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Class2
    {
        public static void Print(string Name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{ Name} => {i}");
            }
        }

        public static void Caller()
        {
            Print("Thread 1");
        }
        public static void Main3()
        {
            Thread sample = new Thread(Caller);
            sample.Start();
            Thread.Sleep(1000);
            sample.Join();
            Thread sample1 = new Thread(() => { Print("Thread 2"); });
            sample1.Start();
        }
    }
}
