using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Class1
    {
        static void Main1()
        {
            //File.WriteAllText("file.txt","Hi I am vikash asdasd \n asdasd ");
            //var data = File.ReadAllLines("file.txt");
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //using (StreamWriter sw = new StreamWriter("file.txt",true))
            //{
            //    sw.WriteLine("Hi my name is vikash and i am from StreamWriter");
            //}
            using (StreamReader sw = new StreamReader("file.txt"))
            {
               Console.WriteLine(sw.ReadToEnd());
            }

        }
    }
}
