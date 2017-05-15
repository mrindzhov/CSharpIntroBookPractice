using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructures.DirectoryTraverser
{
    public static class DirectoryTraverserBFS
    {
        /// <summary>
        /// Traverses and prints given directory with BFS
        /// </summary>
        /// <param name="directoryPath">the path to the directory 
        /// ///which should be traversed</param>
        public static void TraverseDir(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));
            //int counter = 0;
            while (visitedDirsQueue.Count > 0)
            {
                try
                {
                    DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                    Console.WriteLine(currentDir.FullName);
                    DirectoryInfo[] children = currentDir.GetDirectories();
                    foreach (DirectoryInfo child in children)
                    {
                        visitedDirsQueue.Enqueue(child);
                    }
                    //counter++;
                    //if (counter > 50)
                    //{
                    //    break;
                    //}

                }
                catch (Exception)
                {

                    continue;
                }
            }
        }
        public static void Run()
        {
            TraverseDir("C:\\");
        }
    }
}
