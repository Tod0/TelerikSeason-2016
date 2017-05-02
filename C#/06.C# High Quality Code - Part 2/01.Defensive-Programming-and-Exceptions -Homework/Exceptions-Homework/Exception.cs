﻿using System;
using System.Collections.Generic;
using System.Text;

using Exceptions_Homework.Exams;
using Exceptions_Homework.Models;

namespace Exceptions_Homework
{
    class Exception
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentException("Invalid count value!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new ArgumentException("The number is not prime!");
                }
            }
        }

        static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));

            try
            {
                CheckPrime(23);
                Console.WriteLine("The given number is prime.");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("The given number must be prime!", ex);
            }

            try
            {
                CheckPrime(33);
                Console.WriteLine("The given number is prime.");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("The given number must be prime!", ex);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);

            double peterAverageResult = peter.CalcAverageExamResultInPercents();

            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
