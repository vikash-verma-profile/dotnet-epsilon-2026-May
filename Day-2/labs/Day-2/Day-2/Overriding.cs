using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    //base keyword
    class TwoWheeler
    {
        protected int a = 5;
        //public TwoWheeler()
        //{
        //    Console.WriteLine("Hi I am from TwoWheeler");
        //}
        public TwoWheeler(int A)
        {
            a = A;
        }
       
        public virtual void Print()
        {
            Console.WriteLine("Hi I am from TwoWheeler class");
        }
    }
    class Bike:TwoWheeler
    {
        public Bike(int a):base(a)
        {
            base.Print();
        }
        public override void Print()
        {
            Console.WriteLine("Hi I am from Bike class");
        }
        public override string ToString()
        {
            return ($"value of a is :{a}");
        }
    }
    internal class Overriding
    {
        static void Main5()
        {
            //TwoWheeler two=new TwoWheeler();
            //two.Print();
            //Bike bike = new Bike();
            //bike.Print();
            //Console.WriteLine(bike.ToString());

            //TwoWheeler twoWheeler = new Bike();
            //twoWheeler.Print();

            Bike bike = new Bike(10);
            Console.WriteLine(bike.ToString());
        }
    }
}
