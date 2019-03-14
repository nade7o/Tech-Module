﻿using System;
using System.Linq;
namespace _12.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end")
                {
                    break;
                }
                string[] command = input.Split().ToArray();

                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index >= array.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        index++;
                        array = array.Skip(index).Concat(array.Take(index)).ToArray();
                        break;
                    case "max":
                    case "min":
                        MaxOrMin(array, command[0], command[1]);
                        break;
                    case "first":
                    case "last":
                        FirstorLast(array, int.Parse(command[1]), command[2], command[0]);
                        break;
                         
                }
            }
            PrintArray(array);
        }

        private static void FirstorLast(int[] array, int count, string evenOrOdd, string firstOrLast)
        {
            int[] separated = FilterEvenOdd(array, evenOrOdd);
            int[] result = firstOrLast.Equals("last") ? separated.Reverse().Take(count).ToArray() : separated.Take(count).ToArray();

            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            PrintArray(result);
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void MaxOrMin(int[] array, string maxOrMin, string evenOrOdd)
        {
            int[] separated = FilterEvenOdd(array, evenOrOdd);
            if (separated.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(maxOrMin.Equals("max") ? Array.LastIndexOf(array, separated.Max()) : Array.LastIndexOf(array, separated.Min()));
        }

        private static int[] FilterEvenOdd(int[] array, string evenOrOdd)
        {
            int reminder = evenOrOdd.Equals("even") ? 0 : 1;
            return array.Where(n => n  %  2 == reminder).ToArray();
        }
    }
}
