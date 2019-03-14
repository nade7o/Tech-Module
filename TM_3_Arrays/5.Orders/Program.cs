using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            GetPrice(product, quantity);
        }

        private static void GetPrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee": price = 1.50; break;
                case "coke": price = 1.40; break;
                case "water": price = 1.00; break;
                case "snacks": price = 2.00; break;
            }
            double cost = price * quantity;
            Console.WriteLine($"{cost:f2}");
        }
    }
}
