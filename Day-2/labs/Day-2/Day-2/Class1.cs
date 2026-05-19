using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    class Employee
    {
        string name;
        int id;
        int salary;
        public void GetData()
        {
            Console.WriteLine("Enter name of emplooyee");
            name=Console.ReadLine();
            Console.WriteLine("Enter id of emplooyee");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary of emplooyee");
            salary = int.Parse(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine($"The name is {name} salary is {salary} and id is {id}");
        }
    }
    class Class1
    {
        public static void Main2(string[] args)
        {
            Employee[] employees = new Employee[2];
            for (int i = 0; i < employees.Length; i++)
            {
                Employee emp = new Employee();
                emp.GetData();
                employees[i] = emp;
            }
            

            foreach (var item in employees)
            {
                item.Display();
            }
            
        }
	}
    
    
}
