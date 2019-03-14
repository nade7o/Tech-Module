using System;
using System.Collections.Generic;
using System.Linq;
namespace _6.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine()
                .Where(x=>x!=' ') // char масив без празните места
                .ToArray(); 

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (var charachter in words)
            {
                if (!charCounts.ContainsKey(charachter))
                {
                    charCounts[charachter] = 0;
                }
                charCounts[charachter]++;
            }
            foreach (var kvp in charCounts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
