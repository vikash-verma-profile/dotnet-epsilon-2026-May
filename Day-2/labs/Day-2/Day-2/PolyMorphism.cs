using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    public class Sample
    {
        int Number;

        public Sample(int number)
        {
            Number=number;
        }

        public static Sample operator +(Sample s1, Sample s2)
        {
            //Sample s3 = new Sample(0);
            //s3.Number = s1.Number + s2.Number;
            //return s3;
            return new Sample(s1.Number + s2.Number);
        }
        public void Print()
        {
            Console.WriteLine(Number);
        }

    }
    internal class PolyMorphism
    {
        static void Main4()
        {
            Sample s1=new Sample(1);
            Sample s2=new Sample(2);
            Sample s3 = new Sample(0);
            s3 = s1 + s2;
            s3.Print();
        }
    }
}
