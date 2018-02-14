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

            #region Introduction to Arrays
            //// Массивы Arrays
            //int[] array = new int[10];
            //int[] secondArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] thirdArray = new int[] { 1, 2, 3, 4, 5 };

            //// Двумерный и трехмерный массив
            //int[,] twoDimArray = new int[5, 2]
            //{
            //    {1, 2 }, 
            //    {3, 4 }, 
            //    {5, 6 }, 
            //    {7, 8 }, 
            //    {8, 10 }
            //};

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

            //int maxLengthSubarrayIndex = default(int), 
            //    maxLengthSubarrayValue = default(int),
            //    maxSumSubarrayIndex = default(int), 
            //    maxSumSubarrayValue = default(int);

            //int[][] juggerArrayTwo = new int[random.Next(3, 7)][];

            //for(int i = 0; i < juggerArrayTwo.Length; i++)
            //{
            //    juggerArrayTwo[i] = new int[random.Next(1, 6)];
            //    if(juggerArrayTwo[i].Length > maxLengthSubarrayValue)
            //    {
            //        maxLengthSubarrayValue = juggerArrayTwo[i].Length;
            //        maxLengthSubarrayIndex = i;
            //    }
            //    int subarraySum = 0;
            //    for (int j = 0; j< juggerArrayTwo[i].Length; j++)
            //    {
            //        juggerArrayTwo[i][j] = random.Next(1, 10);
            //        Console.Write(juggerArrayTwo[i][j] + " ");
            //        subarraySum += juggerArrayTwo[i][j];
            //    }
            //    if(subarraySum > maxSumSubarrayValue)
            //    {
            //        maxSumSubarrayValue = subarraySum;
            //        maxSumSubarrayIndex = i;
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine(maxLengthSubarrayIndex + " " + maxLengthSubarrayValue);
            //Console.WriteLine(maxSumSubarrayIndex + " " + maxSumSubarrayValue);

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        twoDimArray[i, j] = i * j;
            //        Console.Write(twoDimArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] array = new int[10];

            //for(int i = 0; i < 10; i++)
            //{
            //    array[i] = random.Next(1, 10);
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            //Array.Sort(array);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.ReadLine();

            #endregion

            #region Binary Search Task
            /*
            int[] array = new int[random.Next(50, 100)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Index = " + i + " Value = " + array[i]);
            }

            int valueToFind = Int32.Parse(Console.ReadLine());
            int index = BinarySearch(array, 0, array.Length - 1, valueToFind);

            if (index != -1)
            {
                Console.WriteLine("Found at index = " + index);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            */
            #endregion

            #region Mirror Array Task
            int h = random.Next(3, 8);
            int[][] juggedArray = new int[h][];
            int maxLength = default(int);

            for(int i = 0; i < juggedArray.Length; i++)
            {
                juggedArray[i] = new int[random.Next(1, 5)];
                if(juggedArray[i].Length > maxLength)
                {
                    maxLength = juggedArray[i].Length;
                }

                for(int j = 0; j < juggedArray[i].Length; j++)
                {
                    juggedArray[i][j] = random.Next(1, 10);
                    Console.Write(juggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] mirroredArray = new int[h, maxLength * 2];

            for (int i = 0; i < juggedArray.Length; i++)
            {
                for (int j = 0; j < juggedArray[i].Length; j++)
                {
                    mirroredArray[i,j] = juggedArray[i][j];
                    Console.Write(mirroredArray[i,j] + " ");
                }
                Console.WriteLine();
            }

            int midLine = (maxLength);

            for(int i = 0; i< h; i++)
            {
                for (int j = 0; j < midLine; j++)
                {
                    int oppositeElementIndex = (maxLength * 2 - 1 - j);
                    if(mirroredArray[i, j] != 0)
                    {
                        mirroredArray[i, oppositeElementIndex] = 10 - mirroredArray[i, j];
                    }           
                }
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < maxLength * 2; j++)
                {
                    Console.Write(mirroredArray[i,j] + " ");
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
        }

        static int BinarySearch(int[] array, int left, int right, int value)
        {
            if(left < right)
            {
                int midPoint = left + (right - left) / 2;
                if (array[midPoint] == value)
                {
                    return midPoint;
                }
                else if (array[midPoint] > value)
                {
                    return BinarySearch(array, left, midPoint - 1, value);
                }
                else
                {
                    return BinarySearch(array, midPoint + 1, right, value);
                }
            }
            else
            {
                return -1;
            }      
        } 
    }
}
