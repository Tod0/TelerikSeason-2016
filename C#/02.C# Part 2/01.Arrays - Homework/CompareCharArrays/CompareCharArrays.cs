using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            char[] arr1 = string1.ToCharArray();
            char[] arr2 = string2.ToCharArray();
            int length = Math.Min(arr1.Length, arr2.Length);

            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(">");
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                bool resolved = false;
                for (int i = 0; i < length; i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(">");
                        resolved = true;
                        break;
                    }
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("<");
                        resolved = true;
                        break;
                    }
                }
                if (!resolved)
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
