using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= times; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    sum += lastDigit;
                }
               bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{number} -> {isSpecial}");
            }
        }
    }
}
