using System;

namespace Exam2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array length");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input nums for array A");
            var arrA = InputArray(length);
            Console.WriteLine("Input nums for array B");
            var arrB = InputArray(length);
            Console.WriteLine("Input nums for array C");
            var arrC = InputArray(length);

            Console.WriteLine("Arr A divisible");
            int arrASmallest = PrintNumbersDivisibleBy7(arrA);
            Console.WriteLine("Arr B divisible");
            int arrBSmallest = PrintNumbersDivisibleBy7(arrA);
            Console.WriteLine("Arr C divisible");
            int arrCSmallest = PrintNumbersDivisibleBy7(arrA);
            
            if (arrASmallest == 0 && arrBSmallest == 0 && arrCSmallest == 0)
            {
                Console.WriteLine("There are no numbers that are divisible by 7 in arrays");
            }
            else
            {
                if (arrASmallest < arrBSmallest && arrASmallest < arrCSmallest)
                {
                    Console.WriteLine("Arr As divisible of 7 is smallest: {0}", arrASmallest);
                }
                else if (arrBSmallest < arrASmallest && arrBSmallest < arrCSmallest)
                {
                    Console.WriteLine("Arr Bs divisible of 7 is smallest: {0}", arrBSmallest);
                }
                else
                {
                    Console.WriteLine("Arr Cs divisible of 7 is smallest: {0}", arrCSmallest);
                }
            }

            int[] newArr = ReCalculateArrC(arrC);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"Value index {i} of new arr: {newArr[i]}");
            }
        }

        static int[] ReCalculateArrC(int[] arrC)
        {
            Console.WriteLine("write down N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] newArr = new int[arrC.Length];
            for (int i = 0; i < arrC.Length; i++)
            {
                newArr[i] = arrC[i] - (n - i);
            }

            return newArr;
        }

        static int PrintNumbersDivisibleBy7(int[] arr)
        {
            int smallest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 0 || arr[i] == 7)
                {
                    Console.WriteLine(arr[i] + " is divisible by 7");
                    if (arr[i] < smallest && smallest != 0)
                    {
                        smallest = arr[i];
                    }
                }
            }

            return smallest;
        }

        static int[] InputArray(int length)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Input index {i} of arr: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }
    }
}