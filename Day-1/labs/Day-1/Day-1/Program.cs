
namespace Day_1;
internal class Program
{
    /// <summary>
    /// ajhsdg  hasdf aghsd
    /// </summary>
    /// <param name="args"></param>
    static void Main2(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int Number1 = 2;
        int Number2 = 4;
        Console.WriteLine(Number1+Number2);
        Console.WriteLine("Enter your age");
        int ageNumber=int.Parse(Console.ReadLine());
       // int AgeNumber;
       /*
        * 
        * 
        */
       
        if (ageNumber>18 && ageNumber < 60)
        {
            Console.WriteLine("Hi i am eliginle to vote");
        }
        else if(ageNumber>60)
        {
            Console.WriteLine("I am a senior citizen. and we will take you vote from home");
        }
        else
           Console.WriteLine("No i am  not able to vote");


        int input = 0;
        switch (input)
        {
            case 0:
            case 1:
                Console.WriteLine("I am number 1");
                break;
            default:
                break;
        }


        for (int i = 0; i < 5; i++)
        {
            //Console.WriteLine(i+"\t");
            Console.WriteLine(i);
        }

        //while (true)
        //{

        //}
        //do
        //{
            
        //}
        //while (true);
    }
}

