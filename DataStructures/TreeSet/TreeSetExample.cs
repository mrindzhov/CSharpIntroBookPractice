using System;
using System.Collections.Generic;

namespace DataStructures.TreeSet
{
    class TreeSetExample
    {
        public static void Run()
        {
            TreeSet<string> bandsIvanchoLikes = new TreeSet<string>(
            new[] {
                "manowar", "blind guardian", "dio", "grave digger", "kiss",
                "dream theater", "manowar", "megadeth", "dream theater",
                "dio", "judas priest", "manowar", "kreator",
                "blind guardian", "iron maiden", "accept", "dream theater"
            });
            TreeSet<string> bandsMariikaLikes = new TreeSet<string>(
            new[] {
                "iron maiden", "dio", "accept", "manowar", "slayer",
                "megadeth", "dio", "manowar", "running wild", "grave digger",
                "accept", "kiss", "manowar", "iron maiden", "manowar",
                "judas priest", "iced earth", "manowar", "dio",
                "iron maiden", "manowar", "slayer"
            });
            Console.WriteLine("Ivancho likes these bands: ");
            Console.WriteLine(GetCommaSeparatedList(bandsIvanchoLikes));
            Console.WriteLine();

            Console.WriteLine("Mariika likes these bands: ");
            Console.WriteLine(GetCommaSeparatedList(bandsMariikaLikes));
            Console.WriteLine();
            TreeSet<string> intersectBands = new TreeSet<string>();
            intersectBands.UnionWith(bandsIvanchoLikes);
            intersectBands.IntersectWith(bandsMariikaLikes);

            Console.WriteLine(string.Format("Does Ivancho like Mariika? {0}",
            intersectBands.Count > 5 ? "Yes!" : "No!"));
            Console.WriteLine("Because Ivancho and Mariika both like: ");
            Console.WriteLine(GetCommaSeparatedList(intersectBands));
            Console.WriteLine();
            TreeSet<string> uniounBands = new TreeSet<string>();
            uniounBands.UnionWith(bandsIvanchoLikes);
            uniounBands.UnionWith(bandsMariikaLikes);

            Console.WriteLine("All bands that Ivancho or Mariika like:");
            Console.WriteLine(GetCommaSeparatedList(uniounBands));

        }

        static string GetCommaSeparatedList(IEnumerable<string> items)
        {
            string result = string.Empty;
            int i = 1;
            foreach (string item in items)
            {
                result += item + ", ";
                if (i % 3 == 0) //3 elements on a line
                {
                    result += Environment.NewLine;
                }
                i++;
            }
            if (result != string.Empty)
            {
                //remove the extra separators at the end
                result = result.TrimEnd(',', ' ', '\r', '\n');
            }
            return result;
        }
    }
}
