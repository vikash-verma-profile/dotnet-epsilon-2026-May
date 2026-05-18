namespace Day_3
{

    sealed class Sample
    {

    }
    internal class Program
    {
        static void Main1(string[] args)
        {

            int Number = 5;
            Console.WriteLine("Hello, World!");
            if(Number is int)
            {
                Console.WriteLine("Yes its a Number");
            }
            string s = "sample";
            string sample = s;
            string s1 = "Hi";
            //string s2 = 12 as string;

            Program program = new Program();
            var k = 12 as Object;
            Console.WriteLine(k);
        }
    }
}
