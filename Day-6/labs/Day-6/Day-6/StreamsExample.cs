using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class StreamsExample
    {
        public static void Main2()
        {
            using (FileStream fs = new FileStream("sample5.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("HI I am from Streamwriter");
                }
            }
            using (FileStream fs = new FileStream("sample5.txt", FileMode.Open))
            {

                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
            }
        }
    }
}
