using System;

using Task1.QualityMethods.Enumerations;
using Task1.QualityMethods.Utils;
using Task1.QualityMethods.Models;

namespace Task1.QualityMethods
{
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(MethodCalculation.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(MethodCalculation.ConvertDigitToWordRepresentation(5));

            Console.WriteLine(MethodCalculation.FindMaxElementInArray(5, -1, 3, 2, 14, 2, 3));

            MethodCalculation.PrintNumberAsFormattedString(1.3, FormatType.Round);
            MethodCalculation.PrintNumberAsFormattedString(0.75, FormatType.Percent);
            MethodCalculation.PrintNumberAsFormattedString(2.30, FormatType.AlignRight);

            Console.WriteLine(MethodCalculation.CalculateDistanceBetweenPoints(3, -1, 3, 2.5));
            PositionType linePosition = MethodCalculation.GetLinePosition(3, -1, 3, 2.5);
            Console.WriteLine("Line position: " + linePosition);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 3, 11), "Vidin");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
