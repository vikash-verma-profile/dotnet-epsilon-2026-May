using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class AgeException : Exception
    {
        public AgeException(string message):base(message)
        {
                
        }
    }
    internal class CustomExceptionSample
    {
        public static void Main3()
        {
            try
            {
                int age;
                Console.WriteLine("enter age of customer");
                age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    throw new AgeException("User age is below 18");
                }
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException e) {
                Console.WriteLine($"Please enter correct format{e.Message}");
            }

        }
    }
}
