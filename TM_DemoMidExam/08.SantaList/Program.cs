using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.SantaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split('&').ToList();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Finished!")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                string name = tokens[1];

                if (command == "Bad")
                {
                    if (!names.Contains(name))
                    {
                        names.Insert(0, name);
                    }
                }
                else if (command == "Good")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                }
                else if (command == "Rename")
                {
                    string oldName = tokens[1];
                    string newName = tokens[2];
                    if (names.Contains(oldName))
                    {
                        int index = names.IndexOf(oldName);
                        names.Insert(index, newName);
                        names.RemoveAt(index + 1);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                        names.Add(name);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
