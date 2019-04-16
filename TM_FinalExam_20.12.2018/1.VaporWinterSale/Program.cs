using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gamesWithPrices = new Dictionary<string, double>();
            Dictionary<string, string> gamesWithDlc = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                //WitHer 3:Blood and Beer
                if (input[i].Contains(":"))
                {
                    string[] tokensDlc = input[i].Split(":");
                    string gameName = tokensDlc[0];
                    string dlc = tokensDlc[1];

                    if (gamesWithPrices.ContainsKey(gameName))
                    {
                        gamesWithDlc.Add(gameName, dlc);

                        double increasedPrice = gamesWithPrices[gameName] + gamesWithPrices[gameName] * 0.20;
                        gamesWithPrices[gameName] = increasedPrice;
                    }
                }
                else
                {
                    //WitHer 3-50
                    string[] tokensWithPrices = input[i].Split("-");
                    string gameName = tokensWithPrices[0];
                    double price = double.Parse(tokensWithPrices[1]);

                    gamesWithPrices.Add(gameName, price);
                }
            }
            var gamesLoweredPriceWithoutDlc = new Dictionary<string, double>();
            var gamesLoweredPriceWithDlc = new Dictionary<string, double>();

            foreach (var game in gamesWithPrices)
            {
                string name = game.Key;
                double price = game.Value;

                if (!gamesWithDlc.ContainsKey(name))
                {
                    price = price - (price * 0.2);
                    gamesLoweredPriceWithoutDlc.Add(name, price);
                }
                else
                {
                    price = price - (price * 0.5);
                    gamesLoweredPriceWithDlc.Add(name, price);
                }
            }
            foreach (var game in gamesLoweredPriceWithDlc.OrderBy(x=>x.Value))
            {

                Console.WriteLine($"{game.Key} - {gamesWithDlc[game.Key]} - {game.Value:f2}");
            }

            foreach (var game in gamesLoweredPriceWithoutDlc.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{game.Key} - {game.Value:f2}");
            }
        }
    }
}
