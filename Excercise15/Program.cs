//====================== Задача 15 ===================
//Да се състави алгоритъм за изчисляване на разстоянието d 
//между 2 точки в равнината - A и B, зададени със своите декартови 
//координати - xa, ya и xb, yb.

using System;

namespace Excercise15
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Input Xa: ");
            double xa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Xb: ");
            double xb = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Ya: ");
            double ya = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Yb: ");
            double yb = Convert.ToDouble(Console.ReadLine());

            double distance = CalculateDistance(xa, ya, xb, yb);

            Console.WriteLine($"Distance(d) = {distance}");
        }

        static double CalculateDistance(double xa, double ya, double xb, double yb)
        {
            // Difference in points
            double deltaX = xa - xb;
            double deltaY = ya - yb;

            // Find power of 2
            double powerDeltaX = deltaX * deltaX;
            double powerDeltaY = deltaY * deltaY;

            // Sum of powers
            double sumOfPower = powerDeltaX + powerDeltaY;

            // Square root of sum to get d
            double distance = Math.Sqrt(sumOfPower);

            return distance;
        }
    }
}
