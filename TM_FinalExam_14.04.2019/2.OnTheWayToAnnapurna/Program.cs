using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OnTheWayToAnnapurna
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> diary = new Dictionary<string, List<string>>();

            while ((input=Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                
                if (tokens.Length == 3)
                {
                    string action = tokens[0];
                    string store = tokens[1];
                    string[] items = tokens[2].Split(",");

                    if (items.Length==1)
                    {
                        string item = items[0];
                        if (!diary.ContainsKey(store))
                        {
                            diary.Add(store, new List<string>());
                            diary[store].Add(item);
                        }
                        else
                        {
                            diary[store].Add(item);
                        }
                    }
                    if (items.Length > 1)
                    {
                        if (!diary.ContainsKey(store))
                        {
                            diary.Add(store, new List<string>());
                            for (int i = 0; i < items.Length; i++)
                            {
                                diary[store].Add(items[i]);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < items.Length; i++)
                            {
                                diary[store].Add(tokens[i]);
                            }
                        }
                    }

                }

                else if (tokens.Length == 2)
                {
                    string action = tokens[0];
                    string store = tokens[1];

                    if (diary.ContainsKey(store))
                    {
                        diary.Remove(store);
                    }
                }
            }
            Console.WriteLine("Stores list:");
            foreach (var item in diary.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var i in item.Value)
                {
                    Console.WriteLine($"<<{i}>>");
                }
            }

        }
    }
}
