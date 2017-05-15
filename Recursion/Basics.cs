namespace Recursion
{
    using System;
    using System.Numerics;

    public class Basics
    {
        public static void GenerateVectorsExample()
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Gen01(n - 1, vector);
        }

        public static void Gen01(int index, int[] vector)
        {
            if (index < 0)
            {
                Print(vector);
                return;
            }
            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(index - 1, vector);
            }
        }

        public static void Print(int[] vector)
        {
            foreach (var item in vector)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static int FindSum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + FindSum(arr, ++index);

        }
        public static BigInteger Factorial(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n * Factorial(n - 1);
            }
        }
        public static int Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }

}
