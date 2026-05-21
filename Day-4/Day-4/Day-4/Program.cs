namespace Day_4
{
    class Sample<T>
    {
        T a, b;

        public Sample(T a,T b)
        {
            this.a = a;
            this.b = b;
        }
        public void Print()
        {
            dynamic a1 = a;
            dynamic b1 = b;
            Console.WriteLine($"{a}+{b}={(a1+b1)}");
        }

    }
    internal class Program
    {


        public static void Sum<T>(T a,T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            Console.WriteLine(a1+b1);
        }
        static void Main(string[] args)
        {
            //Sum<int>(1, 2);
            //Sum<string>("Vikash","Verma");

            Sample<int> sample = new Sample<int>(1,2);
            sample.Print();
        }
    }
}
