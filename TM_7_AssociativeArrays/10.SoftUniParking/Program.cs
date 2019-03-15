using System;
using System.Collections.Generic;
using System.Linq;
namespace _10.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string username = input[1];
               

                if (input[0] == "register")
                {
                    string carNumber = input[2];

                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, carNumber);
                        Console.WriteLine($"{username} registered {carNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!dict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        dict.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
