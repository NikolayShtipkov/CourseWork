//====================== Задача 213д ===================
//Задача 213. Да се изчисли:
//д) корен квадратен от н на 1 до 49

using System;

namespace Excercise213d
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 49; i++)
            {
                double number = Convert.ToDouble(i);

                Console.WriteLine($"{i}th root of {i} is: {Math.Pow(number, 1.0 / number)}");
            }
        }
    }
}