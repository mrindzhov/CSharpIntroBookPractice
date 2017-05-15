using System;
using System.Collections.Generic;

namespace DataStructures.Hashing
{
    public class IEqualityExample
    {
        public static void Run()
        {
            IEqualityComparer<Point3D> comparer = new Point3DEqualityComparer();
            Dictionary<Point3D, int> dict =
            new Dictionary<Point3D, int>(comparer);
            dict[new Point3D(1, 2, 3)] = 1;
            Console.WriteLine(++dict[new Point3D(1, 2, 3)]);
        }
    }
}
