using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    abstract class AbstractSample
    {
        public void Print()
        {
            Console.WriteLine("Print example");
        }
        public abstract void Display();
    }

    interface ISample {

        void PrintI();
        
    }   
    internal class AbstractExample: AbstractSample,ISample
    {
        
        static void Main()
        {
            AbstractExample example = new AbstractExample();
            example.Display();
            example.Print();
        }

        public override void Display()
        {
            Console.WriteLine("Hi I am from Implenting class");
        }

        public void PrintI()
        {
            
                Console.WriteLine("I am from Isample");
            
        }
    }
}
