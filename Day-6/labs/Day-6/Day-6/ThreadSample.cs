using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class ThreadSample
    {
        public static void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main5()
        {
            Thread s1 = new Thread(Print);
            s1.Start();
            Thread s2 = new Thread(Print);
            s1.Join();



        }
    }
}
