using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public delegate void Notify();
    internal class Class6
    {

        public static void Message1()
        {
            Console.WriteLine("I am consumer 1");
        }
        public static void Message2()
        {
            Console.WriteLine("I am consumer 2");
        }
        public static void Main7()
        {
            Notify notify = Message1;
            notify += Message2;
            notify -= Message2;
            notify();
        }
    }
}
