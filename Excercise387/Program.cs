using System;

namespace Excercise387
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number K: ");
            double k = Convert.ToDouble(Console.ReadLine());

            List<double> inputList = new List<double>();

            while (true) 
            {
                Console.Write("Input number for list: ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }

                inputList.Add(num);
            }

            double sum = 0;
            foreach (double num in inputList)
            {
                double absK = Math.Abs(k);
                if (num < absK)
                {
                    sum += num;
                }
            }

            Console.WriteLine($"Sum of numbers smaller than absoulute K: {sum}");

            foreach (double num in inputList)
            {
                if (num >= 100 && num <= 666)
                {
                    string letterNumber = Convert.ToString(num);
                    double digitSum = 0;
                    foreach (char ch in letterNumber)
                    {
                        double digit = char.GetNumericValue(ch);
                        digitSum += digit;
                    }

                    if (digitSum % 3 == 0)
                    {
                        Console.WriteLine($"number to print: {num}");
                    }
                }
            }
        }
    }
}