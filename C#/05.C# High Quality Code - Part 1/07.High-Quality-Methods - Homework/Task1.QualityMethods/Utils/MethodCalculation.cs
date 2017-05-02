using System;

using Task1.QualityMethods.Enumerations;

namespace Task1.QualityMethods.Utils
{
    internal class MethodCalculation
    {
        internal static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

            return area;
        }

        internal static string ConvertDigitToWordRepresentation(int digit)
        {
            switch (digit)
            {
                case 0:
                    {
                        return "zero";
                    }
                case 1:
                    {
                        return "one";
                    }
                case 2:
                    {
                        return "two";
                    }
                case 3:
                    {
                        return "three";
                    }
                case 4:
                    {
                        return "four";
                    }
                case 5:
                    {
                        return "five";
                    }
                case 6:
                    {
                        return "six";
                    }
                case 7:
                    {
                        return "seven";
                    }
                case 8:
                    {
                        return "eight";
                    }
                case 9:
                    {
                        return "nine";
                    }
                default:
                    {
                        throw new ArgumentException("Invalid digit!");
                    }
            }
        }

        internal static int FindMaxElementInArray(params int[] elements)
        {
            var length = elements.Length;

            if (elements == null || length == 0)
            {
                throw new ArgumentException("There should be at least one element!");
            }

            int maxNumber = int.MinValue;

            for (int i = 1; i < length; i++)
            {
                maxNumber = Math.Max(maxNumber, elements[i]);
            }

            return maxNumber;
        }

        internal static void PrintNumberAsFormattedString(object number, FormatType format)
        {
            switch (format)
            {
                case FormatType.Round:
                    {
                        Console.WriteLine("{0:f2}", number);
                        break;
                    }
                case FormatType.Percent:
                    {
                        Console.WriteLine("{0:p0}", number);
                        break;
                    }
                case FormatType.AlignRight:
                    {
                        Console.WriteLine("{0,8}", number);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid format!");
                    }
            }
        }

        internal static PositionType GetLinePosition(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            if (firstPointX == secondPointX && firstPointY == secondPointY)
            {
                return PositionType.OverlapedPoints;
            }
            else if (firstPointX == secondPointX)
            {
                return PositionType.Vertical;
            }
            else if (firstPointY == secondPointY)
            {
                return PositionType.Horizontal;
            }
            else
            {
                return PositionType.Other;
            }
        }

        internal static double CalculateDistanceBetweenPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double productX = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double productY = (secondPointY - firstPointY) * (secondPointY - firstPointY);

            double distance = Math.Sqrt(productX + productY);

            return distance;
        }
    }
}
