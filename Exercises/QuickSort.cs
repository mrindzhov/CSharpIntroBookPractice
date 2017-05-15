namespace Exercises
{
    using System;

    public class QuickSort
    {
        static int[] numbers = new int[] { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
        public static void Run()
        {
            QuickSortMethod(numbers, 0, numbers.Length - 1);
            PrintArray(numbers);
        }

        private static void QuickSortMethod(int[] numbers, int lo, int hi)
        {
            if (lo < hi)
            {
                int pivot = Partition(numbers, lo, hi);
                QuickSortMethod(numbers, lo, pivot - 1);
                QuickSortMethod(numbers, pivot + 1, hi);
            }
        }


        private static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        private static int Partition(int[] numbers, int lo, int hi)
        {
            int pivot = numbers[hi];
            int pivIndex = lo;

            for (int i = lo; i < hi; i++)
            {
                if (numbers[i] <= pivot)
                {
                    Swap(pivIndex, i);
                    pivIndex++;
                }
            }

            Swap(hi, pivIndex);
            return pivIndex;
        }

        private static void Swap(int pIndex, int i)
        {
            if (pIndex == i)
            {
                return;
            }
            int temp = numbers[i];
            numbers[i] = numbers[pIndex];
            numbers[pIndex] = temp;
        }

    }
}
