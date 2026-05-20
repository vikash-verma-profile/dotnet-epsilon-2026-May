using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class ValidateAge : Exception
    {
        public ValidateAge(string message) :base(message)
        { 
        }
    }
    internal class Class4
    {
        public static void Main()
        {
            try
            {
                int age = 40;
                if (age > 18)
                {
                    throw new ValidateAge("age is above 18");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
