using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "Contains")
                {
                    int numberToCheck = int.Parse(command[1]);
                    if (numbers.Contains(numberToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    List<double> evenList = new List<double>();
                    foreach (var number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            evenList.Add(number);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenList));
                }
                else if (command[0] == "PrintOdd")
                {
                    List<double> oddList = new List<double>();
                    foreach (var number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            oddList.Add(number);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddList));
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command[0] == "Filter")
                {
                    string symbol = command[1];
                    double number = double.Parse(command[2]);
                    FilterNumbers(symbol, number, numbers);

                }
            }
        }

        private static void FilterNumbers(string symbol, double number, List<double> list)
        {
            List<double> resultList = new List<double>();
            if (symbol == "<")
            {
                foreach (var num in list)
                {
                    if (num < number)
                    {
                        resultList.Add(num);
                    }
                }
                Console.WriteLine(string.Join(" ", resultList));
            }
            else if (symbol == "<=")
            {
                foreach (var num in list)
                {
                    if (num <= number)
                    {
                        resultList.Add(num);
                    }
                }
                Console.WriteLine(string.Join(" ", resultList));
            }
            else if (symbol == ">")
            {
                foreach (var num in list)
                {
                    if (num > number)
                    {
                        resultList.Add(num);
                    }
                }
                Console.WriteLine(string.Join(" ", resultList));
            }
            else if (symbol == ">=")
            {
                foreach (var num in list)
                {
                    if (num >= number)
                    {
                        resultList.Add(num);
                    }
                }
                Console.WriteLine(string.Join(" ", resultList));
            }
        }
    }
}
