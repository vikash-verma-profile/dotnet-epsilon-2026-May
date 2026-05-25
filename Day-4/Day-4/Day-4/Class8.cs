using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Class8
    {
        public static void Main()
        {
            var SampelClass = new { Id=123,Name="Vikash"};

            Console.WriteLine($"{SampelClass.Id}=>{SampelClass.Name}");

            var sample = (int Number) => { Console.WriteLine($"Hi i a method {Number}"); return Number; };

            int x=sample(24);
            Console.WriteLine(x);
        }
    }
}
