using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char cards;
            char[] cardArray = new char[3];


            for (int i = 0; i <= 2; i++)
            {
                cards = char.Parse(Console.ReadLine());
                cardArray[i] += cards;
            }
            cardArray.ToString();
            Console.WriteLine(cardArray);
        }
    }
}
