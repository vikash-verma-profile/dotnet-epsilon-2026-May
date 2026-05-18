using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    enum UseStatus
    {
        Active=1,
        DeActive
    }
    internal class Class2
    {

        static void Main(string[] args)
        {
            Console.WriteLine((int)UseStatus.DeActive);
            Console.WriteLine(Enum.Parse<UseStatus>("1"));

            int[] Numbers = new int[] { 1,2,3};
            int[,] Numbers2D = new int[2,2];
            int[][] NumbersJagged = new int[10][];

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            for (int row = 0; row < 2; row++)
            {

                for (int col = row; col <2 ; col++)
                {
                    Numbers2D[row, col] = row+1;
                }
            }
            for (int row = 0; row < 2; row++)
            {

                for (int col = 0; col < 2; col++)
                {
                    Console.Write(Numbers2D[row,col] +"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
