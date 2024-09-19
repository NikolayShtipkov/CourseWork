//====================== обърни числото 2034 в други бройни системи ==========

using System;

namespace ConvertNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 2034;

            Console.WriteLine($"Decimal: {decimalNumber}");

            DecimalToBinary(decimalNumber);
            Console.WriteLine();
            DecimalToOctal(decimalNumber);
            Console.WriteLine();
            DecimalToHexadecimal(decimalNumber);
            Console.ReadLine();
        }

        static void DecimalToBinary(int decimalNumber)
        {
            int[] binaryArray = new int[32];
            int counter = 0;

            while (decimalNumber > 0)
            {
                binaryArray[counter] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                counter++;
            }

            Console.Write("Binary: ");
            for (int j = counter - 1; j >= 0; j--)
            {
                Console.Write(binaryArray[j]);
            }
        }

        static void DecimalToOctal(int decimalNumber)
        {
            int counter, i = 1;
            int[] octalArray = new int[80];

            counter = decimalNumber;
            while (counter > 0)
            {
                octalArray[i++] = counter % 8;
                counter /= 8;
            }

            Console.Write("Octal: ");
            for (int j = i - 1; j > 0; j--)
            {
                Console.Write(octalArray[j]);
            }
        }

        static void DecimalToHexadecimal(int decimalNumber)
        {
            string hexadecimalNumber = "";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16;
                if (remainder < 10)
                {
                    hexadecimalNumber = remainder + hexadecimalNumber;
                }
                else
                {
                    hexadecimalNumber = (char)(remainder - 10 + 'A') + hexadecimalNumber;
                }

                decimalNumber /= 16;
            }

            Console.WriteLine("Hexadecimal: " + hexadecimalNumber);
        }
    }
}