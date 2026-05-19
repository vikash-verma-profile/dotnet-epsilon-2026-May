using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Sample
    {
        ////fields
        //int _number;

        ////prop
        //public int Number {
        //    get { return _number; } 
        //    set { _number = value; 

        //    } 

        public int Number { get; set; }

        //default constructore
        //public Sample() {
        //    Console.WriteLine("Hi i am being called");
        //}
        //paramterized constructor
        public Sample(int number)
        {
            Number=number;
        }

        //methods
    }
    internal class Calss3
    {
        public static void Main()
        {
                Sample s = new Sample(10);
            // s.Number = 5;
            Console.WriteLine($"{s.Number}");
        }
    }
}
