using System;
using System.Collections.Generic;
using System.Linq;
namespace _6.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0)
            {
                int firstPlayerCard = firstPlayerCards[0];
                int secondPLayerCard = secondPlayerCards[0];
                if (firstPlayerCard > secondPLayerCard)
                {
                    RemoveCards(firstPlayerCards, secondPlayerCards);

                    firstPlayerCards.Add(firstPlayerCard);
                    firstPlayerCards.Add(secondPLayerCard);
                }
                else if (secondPLayerCard > firstPlayerCard)
                {
                    RemoveCards(firstPlayerCards, secondPlayerCards);

                    secondPlayerCards.Add(firstPlayerCard);
                    secondPlayerCards.Add(secondPLayerCard);
                }
                else
                {
                    RemoveCards(firstPlayerCards, secondPlayerCards);
                }
            }
            if (firstPlayerCards.Count > 0)
            {
                int sum = firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondPlayerCards.Count > 0)
            {
                int sum = secondPlayerCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
        static void RemoveCards(List<int>firstPlayerCards, List<int> secondPlayerCards)
        {
            firstPlayerCards.RemoveAt(0);
            secondPlayerCards.RemoveAt(0);
        }
    }
}
