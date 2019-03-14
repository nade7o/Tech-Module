using System;
using System.Collections.Generic;
namespace _3.WodSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            //cute -> adorable, nice, good;

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                words[word].Add(synonym);
            }
            foreach (var kvp in words)
            {
                string word = kvp.Key;
                List<string> synonyms = kvp.Value;

                Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
            }
        }
    }
}
