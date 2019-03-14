using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();

            List<string> result = new List<string>();
            foreach (var item in items)
            {
                List<string> numbers = item.Split(' ').ToList();
                foreach (var number in numbers)
                {
                    if (number != "")
                    {
                        result.Add(number);
                    }
                }
            }
            Console.Write(string.Join(" ", result));
        }
    }
}
