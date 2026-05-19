using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class2
    {
        public  void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void Sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main3()
        {
            Class2 c = new Class2();
            c.Sum(10,20);
            c.Sum("Vikash", "Verma");
            c.Sum(10, 20,30);
        }
    }
}
