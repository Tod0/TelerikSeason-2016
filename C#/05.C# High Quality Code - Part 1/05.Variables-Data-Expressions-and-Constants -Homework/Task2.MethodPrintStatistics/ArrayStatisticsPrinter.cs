using System;
using System.Linq;

namespace Task2.MethodPrintStatistics
{
    public class ArrayStatisticsPrinter
    {
        public void PrintStatistics(double[] array)
        {
            var maxArrayValue = array.Max();
            var minArrayValue = array.Min();
            var avarageArrayValue = array.Average();

            Print(maxArrayValue);
            Print(minArrayValue);
            Print(avarageArrayValue);
        }

        private void Print(double valueToPrint)
        {
            Console.WriteLine("{0:F2}", valueToPrint);
        }
    }
}
