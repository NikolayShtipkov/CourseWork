using System;

namespace LoopPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                int number = 5;
                for (int j = 1; j < i; j++)
                {
                    Console.Write(number);
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
