using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    public class Calculator
    {
        int Number;
        public Calculator(int number)
        {
            Number = number;
        }
        public void Display()
        {
            Console.WriteLine(Number);
        }
        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            Calculator c3 = new Calculator(0);
            c3.Number=c1.Number + c2.Number;
            return c3;
        }

    }
    internal class Class4
    {
        public static void Main()
        {
            Calculator c1=new Calculator(10);
            Calculator c2 = new Calculator(20);
            Calculator c3 = c1 + c2;
            c3.Display();
        }
    }
}
