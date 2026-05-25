using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    //signature
    public delegate void Sum(int a,int b);
    internal class Class5
    {
        public static void Main6()
        {
            Sum s = Add; // linking /mappng delate to a method
            s = Sub;
            s(1, 2);
        }

        public static void Add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}
