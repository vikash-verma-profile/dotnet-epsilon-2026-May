using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Class1
    {
        static void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        //call by value
        static void SwapValue(int a,int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"value of a:{a} , b:{b} in swap method");
        }
        static void SwapRef(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"value of a:{a} , b:{b} in swap method");
        }

        static void PrintValue(int a,int b,out int c)
        {
            c= a + b;
        }
        static void Main(string[] args)
        {
            string name = "vikash";
            //int x = int.Parse(name);
            // int x = int.TryParse(name,out);
            //Console.WriteLine(x);
            //Sum(1,2);
            int a = 1, b = 2;
            int c, d;
            //SwapRef(ref c, ref d);
            //Console.WriteLine($"value of a:{a} , b:{b} in main");
            int sum = 0;
            PrintValue(a, b, out sum);
            Console.WriteLine(sum);
        }
    }
}
