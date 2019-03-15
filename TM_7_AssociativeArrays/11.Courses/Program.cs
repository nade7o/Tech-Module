using System;
using System.Collections.Generic;
using System.Linq;
namespace _11.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            string input = string.Empty;
            
            while ((input=Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ");
                string course = tokens[0];
                string student = tokens[1];

                if (!dict.ContainsKey(course))
                {
                    dict.Add(course, new List<string>());
                    dict[course].Add(student);
                }
                else
                {
                    dict[course].Add(student);
                }
            }
            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
