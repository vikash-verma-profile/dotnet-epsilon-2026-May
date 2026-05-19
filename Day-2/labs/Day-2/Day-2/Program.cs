namespace Day_2
{
    class Person
    {
        //fields
        string name;
        int age;

        //methods
        public void Display()
        {
            Console.WriteLine($"{name},{age}");
        }
        public void GetData()
        {
            name=Console.ReadLine();
            age = Convert.ToInt16(Console.ReadLine());
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Person person = new Person();
            Person[] persons = new Person[2]; 
            //person.name = "vikash";
            //person.age = 12;
            //Console.WriteLine($"{person.name},{person.age}");
            person.GetData();
            person.Display();
        }
    }
}
