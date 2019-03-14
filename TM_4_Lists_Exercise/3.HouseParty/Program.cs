using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 1; i <= commands; i++)
            {
                string text = Console.ReadLine();
                string[] tokens = text.Split();
                string name = tokens[0];

                if (tokens[1] == "is" && tokens[2] == "going!")
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else
                {
                    if (!names.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    names.Remove(name);
                }
            }
            names.ForEach(n => Console.WriteLine(n + " "));
        }
    }
}
