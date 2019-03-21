using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ").ToList();
            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Stop")
                {
                    Console.WriteLine(string.Join(" ", words));
                    break;
                }
                string[] tokens = input.Split(" ");
                string command = tokens[0];

                if (command == "Delete")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < words.Count)
                    {
                        if (index + 1 > 0 && index + 1 < words.Count)
                        {
                            words.RemoveAt(index + 1);
                        }
                    }

                }
                else if (command == "Swap")
                {
                    string word1 = tokens[1];
                    string word2 = tokens[2];

                    if (words.Contains(word1) && words.Contains(word2))
                    {
                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);

                        if (index1 >= 0 && index1 < words.Count && index2 >= 0 && index2 < words.Count)
                        {
                            words.Insert(index1, word2);
                            words.RemoveAt(index1 + 1);
                            words.Insert(index2, word1);
                            words.RemoveAt(index2 + 1);
                        }

                    }
                }
                else if (command == "Put")
                {
                    string word = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (index >= 0)
                    {
                        int previousIndex = index - 1;
                        if (previousIndex >= 0 && previousIndex <= words.Count)
                        {
                            words.Insert(previousIndex, word);
                        }
                    }

                }
                else if (command == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (command == "Replace")
                {
                    string word1 = tokens[1];
                    string word2 = tokens[2];
                    if (words.Contains(word2))
                    {
                        int index = words.IndexOf(word2);
                        words.Insert(index, word1);
                        if (index + 1 < words.Count)
                        {
                            words.RemoveAt(index + 1);
                        }

                    }
                }
            }
        }
    }
}
