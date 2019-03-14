﻿using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int firstNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];
                    
                    if (firstNum <= secondNum)
                    {
                        break;
                    }
                    else if (j == numbers.Length - 1)
                    {
                        Console.Write(firstNum + " ");
                    }
                }
                
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
