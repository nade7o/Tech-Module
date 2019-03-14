using System;

namespace _8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            long factorial1 = GetFActorial(num1);
            long factorial2 = GetFActorial(num2);

            double result = (double) factorial1 / factorial2;
            Console.WriteLine($"{result:f2}");
        }

        private static long GetFActorial(long number)
        {
            long factrorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factrorial *= i;
            }
            return factrorial;
        }
    }
}
