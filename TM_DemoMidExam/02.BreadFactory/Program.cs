using System;
using System.Linq;
namespace _2.BreedFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] workingDayEvents = Console.ReadLine().Split('|').ToArray();
            int initialEnergy = 100;
            int initialCoins = 100;

            for (int i = 0; i < workingDayEvents.Length; i++)
            {
                string[] currentEvent = workingDayEvents[i].Split('-').ToArray();
                string name = currentEvent[0];
                int number = int.Parse(currentEvent[1]);

                if (name == "rest")
                {
                    int currentEnegy = initialEnergy;
                    initialEnergy += number;
                    if (initialEnergy > 100)
                    {
                        Console.WriteLine($"You gained {100 - currentEnegy} energy.");
                        Console.WriteLine($"Current energy: 100.");
                        initialEnergy = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {initialEnergy}.");
                    }
                }
                else if (name == "order")
                {

                    initialEnergy -= 30;
                    if (initialEnergy >= 0)
                    {
                        Console.WriteLine($"You earned {number} coins.");
                        initialCoins += number;
                    }
                    else
                    {
                        initialEnergy += 80;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    string ingredient = name;
                    initialCoins -= number;

                    if (initialCoins > 0)
                    {
                        Console.WriteLine($"You bought {ingredient}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {ingredient}.");
                        return;
                    }
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Energy: {initialEnergy}");

        }
    }
}
