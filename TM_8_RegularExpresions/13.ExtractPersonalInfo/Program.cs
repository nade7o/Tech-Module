using System;

namespace _01.ExtractPersonalInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string age = string.Empty;
            for (int i = 0; i < n; i++)
            {
                // Here is a name @George| and an age #18*
                string line = Console.ReadLine();
                int startIndexName = line.IndexOf('@');
                int endIndexName = line.IndexOf('|');
                name = line.Substring(startIndexName + 1, endIndexName - startIndexName - 1);
                int startIndexAge = line.IndexOf('#');
                int endIndexAge = line.IndexOf('*');
                age = line.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
