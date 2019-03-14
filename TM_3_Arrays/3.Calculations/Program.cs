using System;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            switch (function)
            {
                case "add": Add(a, b); break;
                case "multiply": Multiply(a, b); break;
                case "subtract": Subtract(a, b); break;
                case "divide": Divide(a, b); break;
            }
        }
        private static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        private static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void Add(int num1, int num2)
        {
            Console.WriteLine( num1 + num2);
        }

    }
}
