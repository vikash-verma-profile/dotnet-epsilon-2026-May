using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{

    class IntegerPrinter
    {
        public void Print()
        {
            Console.WriteLine("I am integer printer");
        }
    }
    class StringPrinter
    {
        public void Print()
        {
            Console.WriteLine("I am String printer");
        }
    }

    class Printer<T> where T:class
    {
        public void Print(T value)
        {
            Console.WriteLine($"I am {value} printer");
        }
    }
    internal class GenricsSample
    {
        public static void Main4()
        {
            IntegerPrinter integerPrinter = new IntegerPrinter();
            //integerPrinter.Print();

            //StringPrinter stringPrinter = new StringPrinter();  
            //stringPrinter.Print();

            Printer<IntegerPrinter> printer = new Printer<IntegerPrinter>();
            printer.Print(integerPrinter);
            //Printer<string> printerS = new Printer<string>();
            //printerS.Print("Vakue");

        }
    }
}
