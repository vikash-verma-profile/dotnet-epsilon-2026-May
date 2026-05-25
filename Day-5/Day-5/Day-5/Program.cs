namespace Day_5
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {

            List<Employee> data = new List<Employee>();
            data.Add(new Employee() { Id = 101, Name = "Vikash",DepartmentId=1 });
            data.Add(new Employee() { Id = 102, Name = "Rahul", DepartmentId = 2 });
            data.Add(new Employee() { Id = 103, Name = "Sai", DepartmentId = 3 });
            data.Add(new Employee() { Id = 104, Name = "Tarun", DepartmentId = 1 });

            // Employee sample =data.Where(x => x.Id == 105).First();
            //Employee sample1 =data.Where(x => x.Id == 105).FirstOrDefault();
            //var sample = data.OrderBy(x => x.Name);
            //Console.WriteLine(data.Any(x => x.Id == 105 || x.Name == "Vikash"));

            //first vs firstordefault
            //foreach (var item in sample)
            //{
            //    Console.WriteLine(item.Id+" "+item.Name);
            //}

            List<Department> dataDept = new List<Department>();
            dataDept.Add(new Department() { Id = 1, Name = "IT" });
            dataDept.Add(new Department() { Id = 2, Name = "Sales"});
            dataDept.Add(new Department() { Id = 3, Name = "Admin" });
            dataDept.Add(new Department() { Id = 4, Name = "Support"});

            var result = from n in dataDept where n.Id > 1 select n;



            var finalData = data.Join(dataDept,x=>x.DepartmentId, y => y.Id, (x, y) 
                => new { x.Id,x.Name,DepartmentName=y.Name });

            foreach (var item in finalData)
            {
                Console.WriteLine($"{item.Id}-{item.Name}-{item.DepartmentName}");
            }
        
        }
    }
}
