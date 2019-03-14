using System;
using System.Collections.Generic;
using System.Linq;
namespace _10.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;
            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int currentNumber = 0;
                if (index > list.Count - 1)
                {
                    currentNumber = list[list.Count - 1];
                    list[list.Count - 1] = list[0];
                    sum += currentNumber;
                }
                else if (index < 0)
                {
                    currentNumber = list[0];
                    list[0] = list[list.Count - 1];
                    sum += currentNumber;
                }
                else
                {
                    currentNumber = list[index];
                    list.RemoveAt(index);
                    
                    sum += currentNumber;
                }
                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i] <= currentNumber)
                    {
                        list[i] += currentNumber;
                    }
                    else
                    {
                        list[i] -= currentNumber;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
