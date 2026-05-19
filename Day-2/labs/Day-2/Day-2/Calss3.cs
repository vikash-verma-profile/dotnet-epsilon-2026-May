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
        public Sample(int Number)
        {
            this.Number= Number;
        }

        //methods

        //static
        //this

        public static string Name;

        public static void Print()
        {

        }
    }
    public  class Sample1{

        static Sample1()
        {
            Console.WriteLine("Hi I am static consrictor");
        }
        public Sample1(int Number)
        {
            Console.WriteLine("Number");
        }
        ~Sample1() {  }
    }
    internal class Calss3
    {
        public static void Main3()
        {
            //    Sample s = new Sample(10);
            //// s.Number = 5;
            //Console.WriteLine($"{s.Number}");
            //Sample.Name = "asd";
            //Sample.Print();
            Sample1 s = new Sample1(10);
        }
    }
}
