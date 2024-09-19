using System;

namespace NCurrency
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Leva: ");
            int leva = Convert.ToInt32(Console.ReadLine());

            int count50 = 0;
            int count20 = 0;
            int count10 = 0;
            int count5 = 0;
            int count2 = 0; 
            int count1 = 0; 

            while (leva > 0)
            {
                if (leva - 50 >= 0)
                {
                    leva -= 50;
                    count50++;
                }
                else if (leva - 20 >= 0)
                {
                    leva -= 20;
                    count20++;
                }
                else if(leva - 10 >= 0)
                {
                    leva -= 10;
                    count10++;
                }
                else if (leva - 5 >= 0)
                {
                    leva -= 5;
                    count5++;
                }
                else if (leva - 2 >= 0)
                {
                    leva -= 2;
                    count2++;
                }
                else if (leva - 1 >= 0)
                {
                    leva -= 1;
                    count1++;
                }
            }

            Console.WriteLine($"50s used: {count50}");
            Console.WriteLine($"20s used: {count20}");
            Console.WriteLine($"10s used: {count10}");
            Console.WriteLine($"5s used: {count5}");
            Console.WriteLine($"2s used: {count2}");
            Console.WriteLine($"1s used: {count1}");
        }
    }
}