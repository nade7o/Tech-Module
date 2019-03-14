using System;
using System.Linq;
namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int maxLengh = 1;
            int bestIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxLengh)
                {
                    maxLengh = counter;
                    bestIndex = i + 1;
                }
            }
            int begin = (bestIndex - maxLengh) + 1;
            for (int i = begin; i < begin + maxLengh; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        }
}
