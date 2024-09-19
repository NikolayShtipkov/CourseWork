using System;

namespace Exam1
{
    public class Program
    {
        public static int[]? arr;

        static void Main(string[] args)
        {
            int length;

            while (true)
            {
                Console.WriteLine("Input number in range [2 - 50]: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 2 || n > 50)
                {
                    Console.WriteLine("Invalid number, try again.");
                    continue;
                }

                length = n;
                break;
            }

            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Input index {i} of arr: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Input the value of K: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Sum(k);
            CountOfThreeDigitEvenNumbers();
        }

        static void Sum(int k)
        {
            int sum = 0;

            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i] > k)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("Sum of numbers greater than K({0}) is: {1}", 
                k, sum);
        }

        static void CountOfThreeDigitEvenNumbers()
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string numAsString = arr[i].ToString();
                if (numAsString.Length == 3)
                {
                    int sum = 0;
                    foreach (var ch in numAsString)
                    {
                        int digit = Convert.ToInt32(char.GetNumericValue(ch));
                        sum += digit;
                    }

                    if (sum % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Count of all numbers which digits sum is even are: {0}", count);
        }
    }
}