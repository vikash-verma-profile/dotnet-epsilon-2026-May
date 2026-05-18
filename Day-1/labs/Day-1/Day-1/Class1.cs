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

        static void SampleMethod(int a,int b=10,int c=20)
        {
            Console.WriteLine($"{a},{b}");
        }
        static void Main(string[] args)
        {
            string name = "20";
            //int x = int.Parse(name);
            bool x = int.TryParse(name,out int y);
            Console.WriteLine($"y={y},x={x}");
            Convert.ToInt16(name);
            //Console.WriteLine(x);
            //Sum(1,2);
            //int a = 1, b = 2;
            //int c, d;
            ////SwapRef(ref c, ref d);
            ////Console.WriteLine($"value of a:{a} , b:{b} in main");
            //int sum = 0;
            //PrintValue(a, b, out sum);
            //Console.WriteLine(sum);

            //SampleMethod(b:90,a:80,c:70);
        }
    }
}
