using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Class3
    {
        public static void Main4()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "vikash");
            employees.Add(2, "Ram");
            employees.Add(3, "Kishan");

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Key}-{employee.Value}");
            }

            employees.Remove(1);
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Key}-{employee.Value}");
            }
        }
    }
}
