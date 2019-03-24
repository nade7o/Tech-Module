using System;

namespace _10.MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           string firstNumber = Console.ReadLine().TrimStart('0'); //TrimStart('0') ->Removes all leading occurrences of 0 specified in an array
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }
            string resultAsString = "";
            int rest = 0;

            for (int i = firstNumber.Length-1; i >= 0; i--)
            {
                int currentDigit = int.Parse(firstNumber[i].ToString());
                int currentResult =  currentDigit * secondNumber + rest;

                resultAsString = currentResult % 10 + resultAsString;
                rest = currentResult / 10;
                if (i == 0 && rest> 0)
                {
                    resultAsString = rest + resultAsString;
                }
            }
            Console.WriteLine(resultAsString);
        }
    }
}
