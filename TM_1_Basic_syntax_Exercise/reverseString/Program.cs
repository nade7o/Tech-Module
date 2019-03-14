using System;
using System.Linq;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split(' ');
            for (int i = 0; i < texts.Length / 2; i++)
            {
                string firstText = texts[i];
                int indexOfReversedNum = texts.Length - i - 1;
                texts[i] = texts[indexOfReversedNum];
                texts[indexOfReversedNum] = firstText;

                Console.Write($"{texts[indexOfReversedNum]}");
            }
        }
    }
}
