namespace Day_5
{

    //single cast
    public delegate void MyDelegate(string msg);
    internal class Program
    {
        public static void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main1(string[] args)
        {
            MyDelegate del = Print;
            del += Show;
            del -= Show;
            del("Vikash");
            Console.WriteLine("Hello, World!");
        }
    }
}
