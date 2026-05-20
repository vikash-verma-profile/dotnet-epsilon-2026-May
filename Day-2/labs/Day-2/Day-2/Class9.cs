using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Demo
    {
        //private Demo()
        //  {

        //  }
        //  public Demo getinstance { get; }

        int Number;

        public Demo(int Number)
        {
            this.Number = Number;
        }
        public Demo(Demo d)
        {
            Number = d.Number;
        }
        public void Print()
        {
            Console.WriteLine(Number);
        }
    }
    internal class Class9
    {
        public static void Main()
        {
            Demo demo=new Demo(10);
            Demo d = new Demo(demo);
            d.Print();
        }
    }
}
