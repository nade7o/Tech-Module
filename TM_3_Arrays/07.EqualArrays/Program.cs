using System;
using System.Linq;
namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFirst = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arraySecond = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < arrayFirst.Length; i++)
            {

                if (arrayFirst[i] != arraySecond[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += arrayFirst[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
