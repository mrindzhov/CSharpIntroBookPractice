using DataStructures.Hashing;
using System;

namespace DataStructures.PreventingCollisions.Chaining
{
    class CollisionExample
    {
        public static void Run()
        {
            HashDictionary<Point3D, int> dict = new HashDictionary<Point3D, int>();
            dict[new Point3D(1, 2, 3)] = 1; //Set value
            Console.WriteLine(dict[new Point3D(1, 2, 3)]); //Get value
            //Set Value, overwrite previous value for the same Key
            dict[new Point3D(1, 2, 3)] += 1;
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);
            //Now this Point has the same HashCode as the previos one
            dict[new Point3D(3, 2, 1)] = 42;
            Console.WriteLine(dict[new Point3D(3, 2, 1)]);
            //test if chaining works and elements with equal
            //hashcodes are not overwritten
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);
            //HashCode to test the creation of another entry
            //in the internal table
            dict[new Point3D(1001, 100, 10)] = 1111;
            Console.WriteLine(dict[new Point3D(1001, 100, 10)]);
            //iterate through the Dictionary entries and print values
            foreach (KeyValuePair<Point3D, int> entry in dict)
            {
                Console.WriteLine("Key: " + entry.Key + "; Value: " + entry.Value);
            }
        }
    }
}
