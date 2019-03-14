using System;

namespace _7.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            decimal coins = 0.0m;
            decimal sum = 0.0m;

            while ((input = Console.ReadLine()) != "Start")
            {

                coins = decimal.Parse(input);
                if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1m || coins == 2m)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            if (input == "Start")
            {
                string text = "";

                while ((text = Console.ReadLine()) != "End")
                {
                    string product = text;
                    decimal price = 0.0m;

                    switch (product)
                    {
                        case "Nuts":
                            price = 2.0m; break;
                        case "Water":
                            price = 0.7m; break;
                        case "Crisps":
                            price = 1.5m; break;
                        case "Soda":
                            price = 0.8m; break;
                        case "Coke":
                            price = 1.0m; break;
                        default:
                            Console.WriteLine("Invalid product");
                            continue;
                    }
                    if (sum >= price && (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke"))
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                
                    Console.WriteLine($"Change: {sum:f2}");
                
            }
        }
    }
}
