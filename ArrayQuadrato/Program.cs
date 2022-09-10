using System;

namespace ArrayQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5,5];
            int counter = ;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    counter++;
                    arr[i,j] = (j == 0) ? 0 : counter;
                    Console.Write($"{arr[i,j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}
