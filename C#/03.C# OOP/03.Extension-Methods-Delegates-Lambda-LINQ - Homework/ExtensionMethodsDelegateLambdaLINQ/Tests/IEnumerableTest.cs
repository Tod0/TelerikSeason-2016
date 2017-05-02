namespace ExtensionMethodsDelegateLambdaLINQ.Tests
{
    using System;
    using System.Collections.Generic;

    using Extensions;

    public class IEnumerableTest
    {
        public static void Test()
        {
            Console.WriteLine("List of int = 3, 6, -42, 2, 0");
            IEnumerable<int> someCollection = new List<int>() { 3, 6, -42, 2, 0 };
            Console.WriteLine("Max = {0}", someCollection.MyMax());
            Console.WriteLine("Min = {0}", someCollection.MyMin());
            Console.WriteLine("Product = {0}", someCollection.MyProduct());
            Console.WriteLine("Sum = {0}", someCollection.MySum());
            Console.WriteLine("Average = {0}", someCollection.MyAverage());

            Console.WriteLine();

            Console.WriteLine("Array of double = 0.5, -53.2, 6.6, 4.2");
            IEnumerable<double> doubleArray = new[] { 0.5, -53.2, 6.6, 4.2 };
            Console.WriteLine("Max = {0}", doubleArray.MyMax());
            Console.WriteLine("Min = {0}", doubleArray.MyMin());
            Console.WriteLine("Product = {0}", doubleArray.MyProduct());
            Console.WriteLine("Sum = {0}", doubleArray.MySum());
            Console.WriteLine("Average = {0}", doubleArray.MyAverage());
        }
    }
}
