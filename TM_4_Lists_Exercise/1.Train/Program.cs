using System;
using System.Collections.Generic;
using System.Linq;
namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] command = line.Split();
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int freeSpace = maxCapacity - wagons[i];
                        if (passengers <= freeSpace)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
