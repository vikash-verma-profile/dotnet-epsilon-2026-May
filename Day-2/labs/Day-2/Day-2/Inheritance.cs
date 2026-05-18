using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_2
{
    class Person
    {
       protected string Name;
    }
    class Teacher: Person
    {
        public Teacher(string name)
        {
            Name=name;  
        }
        public void Print()
        {
            Console.WriteLine($"{Name} is a Teacher");
        }
    }
    class Students: Person
    {
        public Students(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"{Name} is a student");
        }
    }
    internal class Inheritance
    {
        static void Main3()
        {
            Person[] person=new Person[3];
            for (int i = 0; i < person.Length; i++)
            {
                if (i == 0)
                {
                    person[i] = new Teacher("Rakesh");
                }
                else
                {
                    person[i] = new Students(Console.ReadLine());
                }
            }

            foreach (var item in person)
            {
               if(item is Teacher)
                {
                    ((Teacher)item).Print();
                }
                else
                {
                    ((Students)item).Print();
                }
            }
        }
    }
}
