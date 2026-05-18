using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class CollectionsGenrics
    {

        public static void Main()
        {

            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee() { Id = 1, Name = "Vikash" };
            employees.Add(emp1);
            employees.Add(new Employee() { Id=1,Name="Vikash"});
            List<int> ints = new List<int>();
            ints.Add(1);    
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dictionay =========");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1,"C#");
            dictionary.Add(3, "JAVA");
            dictionary.Add(2, "Python");
            foreach (KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }

        }
    }
}
