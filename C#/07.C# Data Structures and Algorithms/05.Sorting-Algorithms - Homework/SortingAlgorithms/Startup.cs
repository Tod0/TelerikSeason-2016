using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class Startup
    {
        static void Main()
        {
            var collection = new List<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("All items before sorting:");
            Console.WriteLine(string.Join(" ", collection));
            Console.WriteLine();

            Console.WriteLine("SelectionSorter result:");
            SelectionSorter.Sort(collection);
            Console.WriteLine(string.Join(" ", collection));
            Console.WriteLine();

            collection = new List<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("QuickSorter result:");
            collection = QuickSorter.Sort(collection);
            Console.WriteLine(string.Join(" ", collection));
            Console.WriteLine();

            collection = new List<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Console.WriteLine("MergeSorter result:");
            collection = MergeSorter.Sort(collection);
            Console.WriteLine(string.Join(" ", collection));
            Console.WriteLine();
        }
    }
}
