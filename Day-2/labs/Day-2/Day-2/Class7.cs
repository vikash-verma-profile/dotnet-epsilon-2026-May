using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class A
    {
        //public A()
        //{

        //}
        public A(int Number)
        {
            Console.WriteLine(Number);
        }
    }
    class B:A {
        public B(int Number2):base(Number2)
        {
            Console.WriteLine("B");
        }
    }
    class C : B {
        public C(int Number1):base(Number1)
        {
            Console.WriteLine("C");
        }
    }
    internal class Class7
    {
        public static void Main7()
        {
            C c = new C(10);
        }
    }
}
