using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    //static
    class Student
    {
        //public Student()
        //{

        //}
        public static int Id { get; set; }

       // public int MyProperty { get; set; }
    }
    internal class StaticPart
    {
        static void Main2(string[] args)
        {
            Student.Id = 1;

        }
    }
}
