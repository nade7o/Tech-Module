﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (counts.ContainsKey(wordToLower))
                {
                    counts[wordToLower]++;
                }
                else
                {
                    counts.Add(wordToLower, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
