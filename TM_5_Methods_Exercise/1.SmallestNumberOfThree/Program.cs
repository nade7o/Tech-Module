using System;

namespace _1.SmallestNumberOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            PrintTheSmallestNumber(number1, number2, number3); 
        }

        private static void PrintTheSmallestNumber(int number1, int number2, int number3)
        {
           int smallestNum = Math.Min(number1, number2);
            Console.WriteLine(Math.Min(smallestNum, number3)); 
        }
    }
}
