using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

    internal class Class3
    {
        public static void  Main4()
        {
            var x=Print().Result;
            Console.WriteLine(x);
        }
        public static int Display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            return 1;
        }
        public static async Task<int> Print()
        {
             return await Task.Run(() => { return Display(); });
           
        }
    }
}
