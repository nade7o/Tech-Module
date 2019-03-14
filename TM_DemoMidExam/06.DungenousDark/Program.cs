using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.DungenousDark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            int initialHealth = 100;
            int initialCoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i].Split().ToArray();
                string command = currentRoom[0];
                int number = int.Parse(currentRoom[1]);
                if (command == "potion")
                {
                    int currentHealth = initialHealth;
                    initialHealth += number;
                    if (initialHealth > 100)
                    {
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        initialHealth = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }
                else if (command == "chest")
                {
                    initialCoins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    initialHealth -= number;
                    string monsterName = command;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
