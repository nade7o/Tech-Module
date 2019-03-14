using System;
using System.Linq;
namespace equalSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool hasEqualSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasEqualSum = true;
                    break;
                }
            }
            if (!hasEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
