using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _8.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    break;
                }
                string[] token = input.Split();
                string command = token[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > words.Count - 1)
                    {
                        endIndex = words.Count - 1;
                    }
                    if (startIndex > words.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }
                    Merge(words, startIndex, endIndex);
                }
                else
                {
                    int indexOfWord = int.Parse(token[1]);
                    int parts = int.Parse(token[2]);
                    string element = words[indexOfWord];
                    words.RemoveAt(indexOfWord);
                    
                    List<string> newWords = Divide(element, parts);

                    words.InsertRange(indexOfWord, newWords);
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partLength = element.Length / parts;
            int lastPartLength = partLength + element.Length % parts;

            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i*partLength, partLength);
                if (i == parts - 1)
                {
                    newWord = element.Substring(i * partLength, lastPartLength);
                }
                newWords.Add(newWord);
            }
            return newWords;
        }
        private static void Merge(List<string> words, int startIndex, int endIndex)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i <= endIndex ; i++)
            {
                string word = words[i];
                sb.Append(word);
            }
            words.RemoveRange(startIndex, endIndex - startIndex + 1);
            words.Insert(startIndex, sb.ToString());
        }
    }
}
