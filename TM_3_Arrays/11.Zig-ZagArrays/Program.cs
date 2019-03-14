using System;
using System.Linq;
namespace ZigZagElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                if (i % 2 == 0)
                {
                    first[i] = int.Parse(numbers[0]);
                    second[i] = int.Parse(numbers[1]);
                }
                else
                {
                    first[i] = int.Parse(numbers[1]);
                    second[i] = int.Parse(numbers[0]);
                }
            }
            foreach (int i in first)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in second)
            {
                Console.Write(i + " ");
            }
        }
    }
}
