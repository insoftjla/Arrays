using System;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }

            stopwatch.Start();
            int[] bubbleSort = BubbleSort(array);
            stopwatch.Stop();
            Console.WriteLine("BobbleSort T = {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            int[] selectionSort = SelectionSort(array);
            stopwatch.Stop();
            Console.WriteLine("SelectionSort T = {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            Array.Sort(array);
            stopwatch.Stop();
            Console.WriteLine("Array.Sort T = {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        private static void ArrayPrint(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }

        private static int[] BubbleSort(int[] array)
        {
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            bool isFound = true;
            while (isFound)
            {
                isFound = false;
                for (int i = 0; i < result.Length - 1; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        int tmp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = tmp;
                        isFound = true;
                    }
                }
            }

            return result;
        }

        private static int[] SelectionSort(int[] array)
        {
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);

            for (int i = 0; i < result.Length; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[indexMin])
                    {
                        indexMin = j;
                    }
                }

                int tmp = result[i];
                result[i] = result[indexMin];
                result[indexMin] = tmp;
            }

            return result;
        }

        private static int[] InsertingSort(int[] array)
        {
            int[] result = new int[array.Length];


            return result;
        }
    }
}