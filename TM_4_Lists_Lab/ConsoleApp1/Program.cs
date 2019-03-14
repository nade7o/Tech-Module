using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FilterNumbers(>, 5, )
        }
        private static void FilterNumbers(string symbol, int number, List<int> list)
        {
            if (symbol == "<")
            {
                foreach (var num in list)
                {
                    if (num < number)
                    {
                        Console.WriteLine(num + " ");
                    }
                }
            }
            else if (symbol == "<=")
            {
                foreach (var num in list)
                {
                    if (num <= number)
                    {
                        Console.WriteLine(num + " ");
                    }
                }
            }
            else if (symbol == ">")
            {
                foreach (var num in list)
                {
                    if (num > number)
                    {
                        Console.WriteLine(num + " ");
                    }
                }
            }
            else if (symbol == ">=")
            {
                foreach (var num in list)
                {
                    if (num >= number)
                    {
                        Console.WriteLine(num + " ");
                    }
                }
            }
        }
    }
}
