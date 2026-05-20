using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Class3
    {
        public static void Main4()
        {
            try
            {
                int a, b;
                a = 6; b = 0;
                //int c = a / b;
                //int[] array = new int[2];
                //System.Console.WriteLine(array[3]);
                Console.WriteLine("No exception");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("=========================");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("=========================");
                Console.WriteLine("Some error occured");
            }
            finally
            {
                Console.WriteLine("asdasd");
            }
            
        }
    }
}
