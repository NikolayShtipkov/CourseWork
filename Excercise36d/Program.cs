//====================== Задача 36д ===================
//Задача 36. Запишете израз, който е истина при изпълнение на
//указаното условие и лъжа в противен случай:
//д) всяко от числата x, y, z е положително;

using System;

namespace Excercise36d
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Input X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input Z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            //Simple solution
            if (x > 0 && y > 0 && z > 0)
            {
                Console.WriteLine("True, all numbers are positive.");
            }
            else
            {
                Console.WriteLine("False, not all numbers are positive");
            }

            //Alternative solution
            bool numsArePositive = x > 0 && y > 0 && z > 0;
            Console.WriteLine(numsArePositive);
        }
    }
}