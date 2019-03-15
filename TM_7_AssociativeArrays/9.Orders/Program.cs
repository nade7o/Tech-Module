using System;
using System.Collections.Generic;
using System.Linq;
namespace _9.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var dict = new Dictionary<string, double[]>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] tokens = input.Split().ToArray();

                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!dict.ContainsKey(product))
                {
                    dict.Add(product, new double[2]);
                }
                dict[product][0] = price;
                dict[product][1] += quantity;

            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0]*kvp.Value[1]:f2}");
            }
        }
    }
}
