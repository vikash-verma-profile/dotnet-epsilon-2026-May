using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class Vehicle
    {
        string Make;
        string Model;

        public virtual void Print()
        {
            Console.WriteLine("Hi I am from Base class");
        }
    }
    public class Car : Vehicle
    {
        //public Car(string Name)
        //{
            
        //}
        public override void Print()
        {
            Console.WriteLine("Hi I am from Derived class");
        }
        public override string ToString()
        {
            return "Honda-VRV";
        }
    }
    internal class Class5
    {
        public static void Main4()
        {
            Car c = new Car();
            //  c.Display();
            // c.Print();
            int x = 5;
            string s = x.ToString();
            Vehicle vehicle = new Car();
            vehicle.Print();
            Console.WriteLine(c.ToString());
        }
    }

    class Person
    {

    }
    class Student : Person
    {

    }
    class Teacher : Person
    {

    }
}
