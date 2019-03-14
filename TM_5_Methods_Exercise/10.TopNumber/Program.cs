using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopInteger(number);
        }

        private static void PrintTopInteger(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int topNumber = i;
                int currentNumber = i;
                bool isOdd = false;
                int lastDigit = 0;
                int sumOfDigits = 0;

                while (currentNumber > 0)
                {
                    lastDigit = currentNumber % 10;

                    if (lastDigit%2 != 0)
                    {
                        isOdd = true;
                    }
                    currentNumber /= 10;
                    sumOfDigits += lastDigit;
                }
                if (sumOfDigits % 8 == 0 && isOdd)
                {
                    Console.WriteLine(topNumber);
                }
            }
        }
    }
}
