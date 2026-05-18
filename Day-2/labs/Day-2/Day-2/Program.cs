namespace Day_2
{

    class Employee
    {
        //fields
        //int id;
        string EmployeeName;
        //properties
        //public int Id { get { return id; } set { id = value; } }

        public int Id { get; set; }
        //functions/methods
        public Employee GetData()
        {
            Console.WriteLine("Please enter employee record:");
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(Console.ReadLine());
            employee.EmployeeName = Console.ReadLine();
            return employee;
        }

        public void Display(Employee[] employeeList)
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee.Id}-{employee.EmployeeName}");
            }
        }
        //constructors
        //default constructor
        //public Employee()
        //{

        //}

        private Employee()
        {

        }
        //paramentized constructor

        public int a;
        //this keyword
        public Employee(int a)
        {
            this.a = a;
            Console.WriteLine("This is a constructor  a= "+a+" this.a= "+this.a);
        
        }
        static Employee()

        {
            Console.WriteLine("I am a static contructor");

        }  
        public  Employee(Employee emp)
        {
            this.a = emp.a;
        }
        //destructors
        //indexers

        ~Employee()
        {
            Console.WriteLine("Called");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            
            //Employee[] employeeList = new Employee[3];
            //Employee emp = new Employee();
            //emp.Id = 1;
            //for (int i = 0; i < employeeList.Length; i++)
            //{
            //    employeeList[i] = emp.GetData();
            //}

            //emp.Display(employeeList);
            Employee employee = new Employee(2);
            Employee employee1 = new Employee(employee);
            Console.WriteLine(employee1.a);


           // Employee employee1 = new Employee();

        }
    }
}
