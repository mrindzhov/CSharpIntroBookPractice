using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    class Startup
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            var evenNumbers =
                from num in numbers
                where num % 2 == 0
                select num;

            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");
            }

        }
    }
}
