using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Массивы Arrays
            int[] array = new int[10];
            int[] secondArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] thirdArray = new int[] { 1, 2, 3, 4, 5 };

            // Двумерный и трехмерный массив
            int[,] twoDimArray = new int[5, 2]
            {
                {1, 2 }, 
                {3, 4 }, 
                {5, 6 }, 
                {7, 8 }, 
                {8, 10 }
            };

            //int[,,] threeDimArray = new int[2, 2, 2];
            //int [][] juggedArray = new int[5][];

            //for (int i = 0; i < 5; i++)
            //{
            //    juggedArray[i] = new int[(i * 3) + 1];
            //    for (int j = 0; j < juggedArray[i].Length; j++)
            //    {
            //        juggedArray[i][j] = random.Next(0, 10);
            //        Console.Write(juggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // 3 7
            // 1 6
            // 0 10

            // default(int) = 0

            int maxLengthSubarrayIndex = default(int), 
                maxLengthSubarrayValue = default(int),
                maxSumSubarrayIndex = default(int), 
                maxSumSubarrayValue = default(int);

            int[][] juggerArrayTwo = new int[random.Next(3, 7)][];

            for(int i = 0; i < juggerArrayTwo.Length; i++)
            {
                juggerArrayTwo[i] = new int[random.Next(1, 6)];
                if(juggerArrayTwo[i].Length > maxLengthSubarrayValue)
                {
                    maxLengthSubarrayValue = juggerArrayTwo[i].Length;
                    maxLengthSubarrayIndex = i;
                }
                int subarraySum = 0;
                for (int j = 0; j< juggerArrayTwo[i].Length; j++)
                {
                    juggerArrayTwo[i][j] = random.Next(1, 10);
                    Console.Write(juggerArrayTwo[i][j] + " ");
                    subarraySum += juggerArrayTwo[i][j];
                }
                if(subarraySum > maxSumSubarrayValue)
                {
                    maxSumSubarrayValue = subarraySum;
                    maxSumSubarrayIndex = i;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine(maxLengthSubarrayIndex + " " + maxLengthSubarrayValue);
            Console.WriteLine(maxSumSubarrayIndex + " " + maxSumSubarrayValue);

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        twoDimArray[i, j] = i * j;
            //        Console.Write(twoDimArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
