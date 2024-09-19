//====================== Тест 3 - 3 група I ===================
//Тест 3-3-I. Да се напишат програмите като се направи защита на входните данни.
//Да се дефинира метод по дадена формула.
//Да се състави програма, която въвежда 2 цели положителни числа a и b
//и изчислява F(a+b).F(|a-b|)

using System;

namespace Test3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Calculate F(a + b) and F(|a - b|)
            double sum = a + b;
            double diff = Math.Abs(a - b);

            double F_sum = CalculateF(sum);
            double F_diff = CalculateF(diff);

            // Calculate the result
            double result = F_sum * F_diff;

            Console.WriteLine($"F({sum}) = {F_sum}");
            Console.WriteLine($"F({diff}) = {F_diff}");
            Console.WriteLine($"F({sum}) * F({diff}) = {result}");
        }

        static double CalculateF(double n)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * i * i * i);
            }

            return sum;
        }
    }
}