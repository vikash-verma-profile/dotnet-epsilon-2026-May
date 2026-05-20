using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class Sample
    {
        string Name;
        public Sample(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }

    internal class Class2
    {
        public static void Main()
        {
            Sample s = new Sample("Vikash");
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.ToString());
            Console.WriteLine(s.Equals(s));

            string sample = "Vikash";
            char[] sample1 = new char[] { 'V', 'i', 'k', 'a', 's', 'h' };

            if(sample==new string(sample1))
            {
                Console.WriteLine("Match");
            }
            string sample2 = new string(sample1);
            if (sample1.Equals(sample2))
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("Not Match");
            }

            //is vs as

            Sample s2 = new Sample("SAdasd");
            Sample s3 = new Sample("asdasd");

            if(12 is int)
            {
                Console.WriteLine("Correct=====");
            }
            else
            {
                Console.WriteLine("====InCorrect=====");
            }

            string k = "Vikash" as String;

            object Sample = s3 as object;
        }
    }
}
