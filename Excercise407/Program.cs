//====================== Задача 407 ===================
//Задача 407. Да се въведе едномерен целочислен масив с дължина (брой елементи) в интервала [2, 30]. Да се контролира въвеждането на дължината в този интервал.
//а) Да се напише метод Sredno(k)/Average(k), който връща средноаритметичното на тези елементи на масива, които принадлежат на интервала [-k, k] и се делят на 5 без остатък. Да се въведе от клавиатурата цяло положително число k. Да се извика методът за въведения масив и резултатът от него да се отпечата на екрана.
//б) Да се намери и отпечата на екрана последният минимален елемент на масив и неговият индекс.Задача 407. Да се въведе едномерен целочислен масив с дължина (брой елементи) в интервала [2, 30]. Да се контролира въвеждането на дължината в този интервал.
//а) Да се напише метод Sredno(k)/Average(k), който връща средноаритметичното на тези елементи на масива, които принадлежат на интервала [-k, k] и се делят на 5 без остатък. Да се въведе от клавиатурата цяло положително число k. Да се извика методът за въведения масив и резултатът от него да се отпечата на екрана.
//б) Да се намери и отпечата на екрана последният минимален елемент на масив и неговият индекс.
//using System;

namespace Excercise407
{
    internal class Program
    {
        public static int[]? arr;

        static void Main(string[] args)
        {
            int length;

            while (true)
            {
                Console.WriteLine("Input number in range [2 - 30]: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 2 || n > 30)
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

            Sredno(k);
            MinalRightMostValue();
        }

        static void MinalRightMostValue()
        {
            int minValue = arr[0];
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= minValue)
                {
                    minValue = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"Minimal right-most value: {minValue}, at index: {index}");
        }

        static void Sredno(int k)
        {
            int sum = 0;
            int count = 0;

            int negativeK = -k;
            for (int i = 0;i < arr.Length; i++)
            {
                int num = arr[i];
                if (num >= negativeK && num <= k && num % 5 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No numbers met the criteria");
                return;
            }

            double result = sum / count;

            Console.WriteLine($"Average of numbers between -k({negativeK}) and k({k}) is: {result}");
        }
    }
}