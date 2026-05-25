using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Class7
    {
        public static void Print(string Number)
        {
            Console.WriteLine("Hello i am from Action delegate"+ Number);
        }
        public static string PrintFunc(string Number)
        {
            return $"Hello i am from Action delegate {Number}";
        }
        public static bool CheckOddEven(int Number)
        {
            return (Number%2==0);
        }
        public static void Main8()
        {
            //Action<string> act=Print;
            //act("Vikash");

            // Func<string,string> func = PrintFunc;
            //Console.WriteLine(func("Vikash"));

            Predicate<int> predicate = CheckOddEven;
            Console.WriteLine(CheckOddEven(8));
        }
    }
}
