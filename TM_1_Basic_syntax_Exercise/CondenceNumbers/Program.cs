using System;
using System.Linq;

namespace CondenceNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenght = numbers.Length;

            while (lenght > 1)
            {
                for (int i = 0; i < lenght - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
                lenght--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
