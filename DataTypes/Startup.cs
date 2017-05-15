namespace DataTypes
{
    using System;

    class Startup
    {
        //static void Main(string[] args)
        //{

        //}
        static void Main()
        {
            // Entering the value of the variable n
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            // Printing the bottom part of the triangle
            // that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(" " + i);

            }
            Console.WriteLine();
        }


        private static void PascalTriangleExample()
        {
            const int HEIGHT = 12;
            // Allocate the array in a triangle form
            long[][] triangle = new long[HEIGHT + 1][];
            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }
            // Calculate the Pascal's triangle
            triangle[0][0] = 1;
            for (int row = 0; row < HEIGHT - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            // Print the Pascal's triangle

            for (int row = 0; row < HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
            for (int row = HEIGHT - 2; row >= 0; row--)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }

        }
        private static void SpiralMatrixExample()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            //FillMatrixHorizontalStart(matrix, n);
            FillMatrixVerticalStart(matrix, n);
            PrintMatrix(matrix, n);
        }
        private static void FillMatrixVerticalStart(int[,] matrix, int n)
        {
            int row = 0;
            int col = 0;

            // the most important part of this method is the change of the directions:
            // right -> down -> left -> up -> right etc.
            string direction = "down";
            int maxRotations = n * n;

            // this loop counts the number of numbers printed, and changes the direction
            // int two case: 
            // 1st if we have reached the end of the row;
            // 2nd, with further rotations, if a given position in the square spiral is already occupied by a number
            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row--;
                    col++;
                }
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }
                if (direction == "left" && matrix[row, col] != 0)
                {
                    direction = "down";
                    col++;
                    row++;
                }
                // the above is how we move the cursor

                // the code below is allocation of i values into the square matrix
                matrix[row, col] = i;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
        }
        private static void FillMatrixHorizontalStart(int[,] matrix, int n)
        {
            int row = 0;
            int col = 0;

            // the most important part of this method is the change of the directions:
            // right -> down -> left -> up -> right etc.
            string direction = "right";
            int maxRotations = n * n;

            // this loop counts the number of numbers printed, and changes the direction
            // int two case: 
            // 1st if we have reached the end of the row;
            // 2nd, with further rotations, if a given position in the square spiral is already occupied by a number
            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    // with down direction it might seem that we can keep the value of the column constant,
                    // this is not the case, as the Console.Write() method will try to do the next print on (column + 1)
                    // that is why we need to constantly return it back with col--
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }
                // the above is how we move the cursor

                // the code below is allocation of i values into the square matrix
                matrix[row, col] = i;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
        }
        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static void StringCompareExample()
        {
            string str = "beer";
            string anotherStr = str;
            string thirdStr = "bee";
            thirdStr = thirdStr + 'r';
            Console.WriteLine("str = {0}", str);
            Console.WriteLine("anotherStr = {0}", anotherStr);
            Console.WriteLine("thirdStr = {0}", thirdStr);
            Console.WriteLine(str == anotherStr); // True - same object
            Console.WriteLine(str == thirdStr); // True - equal objects
            Console.WriteLine((object)str == (object)anotherStr); // True
            Console.WriteLine((object)str == (object)thirdStr); // False 
        }
        private static void ReadKeyExample()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Character entered: " + key.KeyChar);
            Console.WriteLine("Special keys: " + key.Modifiers);
            Console.WriteLine("Key: " + key.Key);
        }
        private static void ConsoleReadMethodExample()
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                if (codeRead != 0)
                {
                    Console.Write((char)codeRead);
                }
            }
            while (codeRead != 10);
        }
        private static void CustomNumericFormatsExample()
        {
            Console.WriteLine("{0:0.00}", 1);
            //Output: 1,00
            Console.WriteLine("{0:#.##}", 0.234);
            //Output: ,23
            Console.WriteLine("{0:#####}", 12345.67);
            //Output: 12346
            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
            //Output: (02) 934 25 25
            Console.WriteLine("{0:%##}", 0.234);
            //Output: %23
        }
        private static void StandartNumericFormatsExample()
        {
            Console.WriteLine("{0:C2}", 123.456);
            //Output: 123,46 лв.
            Console.WriteLine("{0:D6}", -1234);
            //Output: -001234
            Console.WriteLine("{0:E2}", 123);
            //Output: 1,23Е+002
            Console.WriteLine("{0:F2}", -123.456);
            //Output: -123,46
            Console.WriteLine("{0:N2}", 1234567.8);
            //Output: 1 234 567,80
            Console.WriteLine("{0:P}", 0.456);
            //Output: 45,60 %
            Console.WriteLine("{0:X}", 254);
            //Output: FE
        }
        private static void BitsOperationsExample()
        {
            int a = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a << i);
            }
            //Console.WriteLine(a << 1);
            //Console.WriteLine(a << 1 << 1);
            //Console.WriteLine(a << 1 << 1 << 1);
        }
        private static void ValueAssigningExample()
        {
            int a = 6;
            int b = 3;
            Console.WriteLine(a + b / 2); // 7
            Console.WriteLine((a + b) / 2); // 4
            string s = "Beer";
            Console.WriteLine(s is string); // True
            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified"); // Unspecified
            Console.WriteLine(notNullString ?? "Specified");
        }
        private static void DivideByZeroExample()
        {
            int num = 1;
            double denum = 0; // The value is 0.0 (real number)

            int zeroInt = (int)denum; // The value is 0 (integer number)
            Console.WriteLine(num / denum); // Infinity
            Console.WriteLine(denum / denum); // NaN
            Console.WriteLine(zeroInt / zeroInt); // DivideByZeroException
        }
    }
}