namespace Exercises
{
    using System;

    public class MergeSort
    {
        static int[] numbers = new int[] { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };

        public static void Run()
        {
            MergeSortMethod(numbers, 0, numbers.Length - 1);
            PrintArray(numbers);
        }
        private static void MergeSortMethod(int[] numbers, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid = (hi + lo) / 2;
                MergeSortMethod(numbers, lo, mid);
                MergeSortMethod(numbers, (mid + 1), hi);
                Merge(numbers, lo, (mid + 1), hi);
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
        private static void Merge(int[] input, int left, int mid, int right)
        {
            //Merge procedure takes theta(n) time
            int[] temp = new int[input.Length];
            int i, leftEnd, lengthOfInput, tmpPos;
            leftEnd = mid - 1;
            tmpPos = left;
            lengthOfInput = right - left + 1;

            //selecting smaller element from left sorted array or right sorted array and placing them in temp array.
            while ((left <= leftEnd) && (mid <= right))
            {
                if (input[left] <= input[mid])
                {
                    temp[tmpPos++] = input[left++];
                }
                else
                {
                    temp[tmpPos++] = input[mid++];
                }
            }
            //placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tmpPos++] = input[left++];
            }

            //placing remaining element in temp from right sorted array
            while (mid <= right)
            {
                temp[tmpPos++] = input[mid++];
            }

            //placing temp array to input
            for (i = 0; i < lengthOfInput; i++)
            {
                input[right] = temp[right];
                right--;
            }
        }
    }
}
