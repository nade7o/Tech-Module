using System;
using System.Collections.Generic;
using System.Linq;
namespace _12.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dict.ContainsKey(student))
                {
                    dict.Add(student, new List<double>());
                    dict[student].Add(grade);
                }
                else
                {
                    dict[student].Add(grade);
                }
            }
        }
    }
}
