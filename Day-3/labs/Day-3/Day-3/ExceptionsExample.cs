using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class ExceptionsExample
    {
        static void Main2(string[] args)
        {
            try
            {
                //int[] array = new int[1];
                //Console.WriteLine(array[2]);
                //int a = 1, b = 0;
                //int c = a / b;
                //Console.WriteLine(c);

                Console.WriteLine("Correct code");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Hi i a m in catch");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Hi i a m in catch");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some problem have occured !! please reach to customer care!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Hi I am a finally block");
            }
        }
    }
}
