using System;

namespace Arrays
{
    public static class Arrays
    {

        public static void BubbleSort(int[] array)
        {
            var isFound = true;
            while (isFound)
            {
                isFound = false;
                for (var i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1, array);
                        isFound = true;
                    }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var indexMin = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[indexMin])
                        indexMin = j;

                Swap(i, indexMin, array);
            }
        }

        public static void InsertingSort(int[] array)
        {
            for (var i = 1; i < array.Length ; i++)
            {
                for (var j = i; (j > 0)  && (array[j - 1] > array[j]); j--)
                    Swap(j, j - 1, array);
            }
        }

        private static void Swap(int index1, int index2, int[] array)
        {
            var tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }
    }
}
