using System;

namespace _13.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double total = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Game Time")
            {
               
                string gameName = input;
                double price = 0;
                
                switch (gameName)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not found");continue;
                }
                if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {gameName}");
                    currentBalance -= price;
                    total += price;
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    input = Console.ReadLine();
                    return;
                }
            }
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${currentBalance:f2}");
            }

        }
    }
}
