using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class Startup
    {
        static void Main()
        {
            int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(LinearSearch.ArrayLinearSearch(array, 5));
            Console.WriteLine(BinarySearch.ArrayBinarySearch(array, 4, 0, 8));
        }
    }
}
