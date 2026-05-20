namespace Day_2
{
    class Person2
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
            Person2 Person2 = new Person2();
            Person2[] Person2s = new Person2[2]; 
            //Person2.name = "vikash";
            //Person2.age = 12;
            //Console.WriteLine($"{Person2.name},{Person2.age}");
            Person2.GetData();
            Person2.Display();
        }
    }
}
