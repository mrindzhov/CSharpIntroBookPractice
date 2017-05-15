namespace Exercises
{
    using System;

    public class Basics
    {
        public static void Run()
        {
            BitsExample();
            TestMetrics();
            MatrixNoob();
            FibonacciOneHundred();

        }

        private static void BitsExample()
        {
            int a = 32750;
            int b = a / 10 / 10;
            Console.WriteLine(b % 10 == 7);

            int n = 35; // 00100011
            int p = 5;
            int i = 1; // 00000001
            int mask = i << p; // Move the 1st bit left by p positions
                               // If i & mask are positive then the p-th bit of n is 1
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }

        private static void FibonacciOneHundred()
        {
            ulong f = 0;
            ulong s = 1;
            for (int j = 0; j < 100; j++)
            {
                Console.Write(f + " ");
                ulong av = f + s;
                f = s;
                s = av;
            }
        }

        private static void MatrixNoob()
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int col = row; col < row + num; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        private static void TestMetrics()
        {
            float f = 0.000001f;
            double db = 0.000001d;
            decimal dc = 0.000001m;

            float sum = 0;
            double sumDb = 0;
            decimal sumDc = 0;
            for (int i = 0; i < 50000000; i++)
            {
                sum += f;
                sumDb += db;
                sumDc += dc;
            }
            Console.WriteLine(sum);
            Console.WriteLine(sumDb);
            Console.WriteLine(sumDc);
        }
    }
}
