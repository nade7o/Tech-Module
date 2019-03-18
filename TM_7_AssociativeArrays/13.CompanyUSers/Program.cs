using System;
using System.Collections.Generic;
using System.Linq;
namespace _13.CompanyUSers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split("->").ToArray();
                string company = tokens[0];
                string id = tokens[1];

                if (!database.ContainsKey(company))
                {
                    database.Add(company, new List<string>());
                    database[company].Add(id);
                }
                else if (database.ContainsKey(company) && !database[company].Contains(id))
                {
                    database[company].Add(id);
                }
            }
            foreach (var kvp in database.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"--{id}");
                }
            }
        }
    }
}
