using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeizeFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("#").ToArray();
            int water = int.Parse(Console.ReadLine());
            double totalEffort = 0;
            double totalFire = 0;
            List<int> values = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] currentFireCell = input[i].Split(" = ").ToArray();
                string typeOfFire = currentFireCell[0];
                int value = int.Parse(currentFireCell[1]);
                double currentEffort;
                if (water <= 0)
                {
                    return;
                }
                if (typeOfFire == "High")
                {
                    if (value >= 81 && value <= 125)
                    {
                        water -= value;
                        if (water < 0)
                        {
                            break;
                        }
                        currentEffort = 0.25 * value;
                        totalEffort += currentEffort;
                        totalFire += value;
                        values.Add(value);
                    }
                }
                else if (typeOfFire == "Medium")
                {
                    if (value >= 51 && value <= 80)
                    {
                        water -= value;
                        if (water < 0)
                        {
                            break;
                        }
                        currentEffort = 0.25 * value;
                        totalEffort += currentEffort;
                        values.Add(value);
                        totalFire += value;
                    }
                }
                else if (typeOfFire == "Low")
                {
                    if (value >= 1 && value <= 50)
                    {
                        water -= value;
                        if (water < 0)
                        {
                            break;
                        }
                        currentEffort = 0.25 * value;
                        totalEffort += currentEffort;
                        values.Add(value);
                        totalFire += value;
                    }
                }
            }
            Console.WriteLine("Cells:");
            foreach (var item in values)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
