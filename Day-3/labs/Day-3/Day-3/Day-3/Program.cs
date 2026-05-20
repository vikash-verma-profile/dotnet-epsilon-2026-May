namespace Day_3
{

    abstract class Vehicle
    {
        public int Make { get; set; }
        public int Model { get; set; }
        public abstract void Print();
        public void Display()
        {

        }
       
    }
    class Car : Vehicle
    {
        public override void Print()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello, World!");
        }
    }
}
