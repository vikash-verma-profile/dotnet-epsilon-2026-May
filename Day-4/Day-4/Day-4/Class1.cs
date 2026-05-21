using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    //var vs dyamic
    internal class Class1
    {
        public static void Main1()
        {
            //var x = 1;
            //x = "Vikash";
            //Console.WriteLine(x);

            dynamic x = 1;
            x = "Vikash";
            Console.WriteLine(x);
        }
    }
}
