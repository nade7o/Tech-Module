using System;

namespace _4.PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
            PrintReversedTriangle(n -1);
        }

        private static void PrintReversedTriangle(int n)
        {
            for (int row = n; row >= 1; row--)
            {
                PrintNumbersInRows(row);
            }
        }
        private static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n ; row++)
            {
                PrintNumbersInRows(row);
            }
        }
        private static void PrintNumbersInRows(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
