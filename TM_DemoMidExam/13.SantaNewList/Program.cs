using System;
using System.Collections.Generic;
using System.Linq;
namespace _13.SantaNewList
{


    class Children
    {
        public string Name;
        public string Present;
        int Price;

        public Children(string name, string present, int price)
        {
            Name = name;
            Present = present;
            Price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Children> listOfChildren = new List<Children>();
            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (command == "Remove")
                {

                }
                string[] tokens = command.Split("->");
                string name = tokens[0];
                string present = tokens[1];
                int price = int.Parse(tokens[2]);
                var child = new Children(name, present, price);

                if (listOfChildren.Contains(child))
                {
                    listOfChildren.Find(x => x == child);
                }
                else
                {
                    listOfChildren.Add(child);
                }
            }
        }
    }
}
