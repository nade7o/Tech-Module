using System;
using System.Collections.Generic;
using System.Linq;
namespace _5.RemoveNegativeandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> positiveList = new List<int>();
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveList.Add(number);
                }
            }
            if (positiveList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                positiveList.Reverse();
                Console.WriteLine(string.Join(" ", positiveList));
            }
        }
    }
}
