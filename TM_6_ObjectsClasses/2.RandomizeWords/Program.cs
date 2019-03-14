using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random rnd = new Random();
            foreach (var word in words)
            {
                int newIndex = rnd.Next(0, words.Count);
            }
        }
    }
}
