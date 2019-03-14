using System;
using System.Collections.Generic;
using System.Linq;
namespace _7.MinerTast

{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            string product = string.Empty;

            while ((product = Console.ReadLine())!= "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(product))
                {
                    resources[product] = quantity;
                }
                else
                {
                    resources[product] += quantity;
                }
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
