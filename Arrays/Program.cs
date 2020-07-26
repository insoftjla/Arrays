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

            int[] array = new int[10000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }

            stopwatch.Start();
            var bubbleSort = new int[array.Length];
            Array.Copy(array, bubbleSort, array.Length);
            Arrays.BubbleSort(bubbleSort);
            stopwatch.Stop();
            Console.WriteLine("BobbleSort T = {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            var selectionSort = new int[array.Length];
            Array.Copy(array, selectionSort, array.Length);
            Arrays.SelectionSort(selectionSort);
            stopwatch.Stop();
            Console.WriteLine("SelectionSort T = {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            var insertingSort = new int[array.Length];
            Array.Copy(array, insertingSort, array.Length);
            Arrays.SelectionSort(insertingSort);
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
        
    }
}