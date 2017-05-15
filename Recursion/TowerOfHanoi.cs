namespace Recursion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TowerOfHanoi
    {
        private static int stepsTaken = 0;

        private static Stack<int> sourceRod;
        private static readonly Stack<int> destinationRod = new Stack<int>();
        private static readonly Stack<int> spareRod = new Stack<int>();

        public static void Run()
        {
            Console.Write("Enter disks count: ");
            int numberOfDisks = int.Parse(Console.ReadLine());
            sourceRod = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            PrintRods();
            MoveDisks(numberOfDisks, sourceRod, destinationRod, spareRod);
        }

        private static void MoveDisks(int bottomDisk, Stack<int> sourceRod, Stack<int> destinationRod, Stack<int> spareRod)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destinationRod.Push(sourceRod.Pop());
                Console.WriteLine($"Steps taken #{stepsTaken}: Moved disk: {bottomDisk}");
                PrintRods();
            }
            else
            {
                MoveDisks(bottomDisk - 1, sourceRod, spareRod, destinationRod);
                stepsTaken++;
                destinationRod.Push(sourceRod.Pop());
                Console.WriteLine("Step #{0}: Moved disk {1}", stepsTaken, bottomDisk);
                PrintRods();
                MoveDisks(bottomDisk - 1, spareRod, destinationRod, sourceRod);
            }
        }
        private static void PrintRods()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Source: {0}", string.Join(", ", sourceRod.Reverse()));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Destination: {0}", string.Join(", ", destinationRod.Reverse()));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spare: {0}", string.Join(", ", spareRod.Reverse()));
            Console.WriteLine();
        }

    }
}
