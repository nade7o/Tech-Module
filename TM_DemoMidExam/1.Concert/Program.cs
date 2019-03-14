using System;
using System.Collections.Generic;
using System.Linq;
namespace _1.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<string> members = new List<string>();
            List<string> bands = new List<string>();

            while ((line = Console.ReadLine()) != "start of concert")
            {
                string[] tokens = line.Split("; ");
                string command = tokens[0];
                string bandName = tokens[1];

                if (command == "Play")
                {
                    int time = int.Parse(tokens[2]);
                }                

                if (command == "Add")
                {
                    string membersName = Console.ReadLine();
                    Console.WriteLine(membersName);
                }
            }
        }
    }
}
