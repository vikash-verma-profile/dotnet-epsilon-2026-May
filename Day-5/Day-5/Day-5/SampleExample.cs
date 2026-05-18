using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class SampleExample
    {

        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static void Main3()
        {
            var x = new { id = 1, name = "Vikash" };
            var y=()=>Console.WriteLine("Hello from vikash");
            Console.WriteLine($"{x.id}-{x.name}");
            y();

            Action<string> act = x => Console.WriteLine(x);
            act("Using Action");

            Action<int> act1 = x => Console.WriteLine(x);
            act1(12);

            Func<int, int, int> add;
            var s= (int a, int b) => a + b;

            add = Sum;


            Console.WriteLine(add(2, 3));

            Predicate<int> isEven = (x) => x % 2 == 0;
            Console.WriteLine(isEven(4));


        }
    }
}
