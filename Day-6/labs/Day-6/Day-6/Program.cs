namespace Day_6
{

    partial class Sample
    {
        public void Print()
        {
            Console.WriteLine("Hi I am coming from part 1");
        }
    }

    partial class Sample {
        public void Display()
        {
            Console.WriteLine("Hi I am coming from part 2");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            string filePath = "sample3.txt";
            if (File.Exists(filePath))
            {
                File.AppendAllLines(filePath, new string[] { "My Name is Vikash new " });
            }
            else
            {
                using (File.Create(filePath));
                //File.Create(filePath).Dispose() ;
                File.WriteAllLines(filePath, new string[] { "My Name is Vikash new " });

            }
            var data=File.ReadAllLines(filePath);
            foreach (var line in data)
            {
                Console.WriteLine(line);
            }
           
           //Sample sample=new Sample();
           // sample.Display();
           // sample.Print();
            Console.WriteLine("Hello, World!");
        }
    }
}
