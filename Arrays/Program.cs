using System;
using System.Diagnostics;
using System.Threading.Channels;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            int[] array = new int[10000];
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
            int[] insertingSort = InsertingSort(array);
            stopwatch.Stop();
            Console.WriteLine("InsertingSort T = {0}ms", stopwatch.ElapsedMilliseconds);
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
            var result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            var isFound = true;
            while (isFound)
            {
                isFound = false;
                for (var i = 0; i < result.Length - 1; i++)
                    if (result[i] > result[i + 1])
                    {
                        Swap(i, i + 1, result);
                        isFound = true;
                    }
            }

            return result;
        }

        private static int[] SelectionSort(int[] array)
        {
            var result = new int[array.Length];
            Array.Copy(array, result, array.Length);

            for (var i = 0; i < result.Length; i++)
            {
                var indexMin = i;
                for (int j = i + 1; j < result.Length; j++)
                    if (result[j] < result[indexMin])
                        indexMin = j;

                Swap(i, indexMin, result);
            }

            return result;
        }

        private static int[] InsertingSort(int[] array)
        {
            var result = new int[array.Length];
            Array.Copy(array, result, result.Length);
            if (result.Length < 2) return result;

            for (var i = 1; i < result.Length ; i++)
            {
                for (var j = i; (j > 0)  && (result[j - 1] > result[j]); j--)
                    Swap(j, j - 1, result);
            }

            return result;
        }

        private static void Swap(int index1, int index2, int[] array)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }
    }
}