using System;
using System.Collections.Generic;
using System.Linq;
namespace _14.softUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsAndpoints = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = input.Split("-").ToArray();
                string username = tokens[0];
                

                if (tokens[1] == "banned")
                {
                    studentsAndpoints.Remove(username);
                }
                else
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);
                    if (!studentsAndpoints.ContainsKey(username))
                    {
                        studentsAndpoints.Add(username, points);
                    }
                    else
                    {
                        if (points > studentsAndpoints[username])
                        {
                            studentsAndpoints[username] = points;
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
            }
            Console.WriteLine("Results:");
            foreach (var kvp in studentsAndpoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
