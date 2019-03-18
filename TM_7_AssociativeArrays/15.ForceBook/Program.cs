using System;
using System.Collections.Generic;
using System.Linq;
namespace _15.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceBook = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    //forceSide | forceUSer
                    string[] tokens = input.Split("|").ToArray();
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                        
                    }
                    if (!forceBook.Any(x=>x.Value.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }

                else if (input.Contains("->"))
                {
                    string[] tokens = input.Split("->").ToArray();
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            item.Value.Remove(forceUser);
                            forceBook[forceSide].Add(forceUser);
                            break;
                        }
                    }
                    if (!forceBook.Any(x=>x.Value.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side");
                  
                }
            }
            foreach (var item in forceBook.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key)) 
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var item2 in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"!{item2}");
                }
            }
        }
    }
}
