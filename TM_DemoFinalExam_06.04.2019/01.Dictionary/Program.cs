using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End" || input == "List")
                {
                    break;
                }

                string[] tokens = input.Split(new char[] { '|', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray(); 
                for (int i = 0; i < tokens.Length; i+=2)
                {
                    string word = tokens[i];
                    string meaning = tokens[i + 1];
                    if (!dictionary.ContainsKey(word))
                    {
                        dictionary.Add(word, new List<string>());
                        dictionary[word].Add(meaning);
                    }
                    else
                    {
                        dictionary[word].Add(meaning);
                    }
                }
                input = Console.ReadLine();
                string[] words = input.Split("|", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                foreach (var word in words)
                {
                    foreach (var item in dictionary)
                    {
                        if(word == item.Key)
                        {
                            Console.WriteLine(word);
                            List<String> sampleList = item.Value.OrderByDescending(s => s.Length).ToList();
                            foreach (var meaning in sampleList)
                            {
                                Console.WriteLine($" -{meaning}");
                            }
                        }
                    }
                }
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else if (input == "List")
                {
                    foreach (var kvp in dictionary.OrderBy(x=>x.Key))
                    {
                        Console.Write(kvp.Key + " ");
                    }
                    break;
                }
            }
        }
    }
}
