using System;
using System.Text.RegularExpressions;
namespace _04.ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeDishes = 0;
            int timeCleaning = 0;
            int timeLaundry = 0;
            int totalMinutes = 0;

            string dishesPattern = @"(?<=<)[a-z0-9]+(?=>)";
            //starts with "<" and ends with ">" and has only lowercase letters and digits

            string cleaningPattern = @"(?<=\[)[A-Z0-9]+(?=\])";
            //starts with "[" and ends with "]" and has only uppercase letters and digits

            string laundryPattern = @"(?<={).+(?=})";
            //starts with "{" and ends with "}" and has any character in the middle

            string input = Console.ReadLine();

            while (input != "wife is happy")
            {
                Match dishesMatch = Regex.Match(input, dishesPattern);
                Match cleaningMatch = Regex.Match(input, cleaningPattern);
                Match laundryMatch = Regex.Match(input, laundryPattern);

                if (dishesMatch.Success)
                {
                    string dishesAsString = dishesMatch.ToString();
                    string numPattern = @"\d"; //\d - matches every number from 0-9

                    MatchCollection nums = Regex.Matches(dishesAsString, numPattern);

                    foreach (var match in nums)
                    {
                        int num = int.Parse(match.ToString());
                        timeDishes += num;
                    }
                }
                else if (cleaningMatch.Success)
                {
                    string cleaningAsString = cleaningMatch.ToString();
                    string numPattern = @"\d";

                    MatchCollection nums = Regex.Matches(cleaningAsString, numPattern);

                    foreach (var match in nums)
                    {
                        int num = int.Parse(match.ToString());
                        timeCleaning += num;
                    }
                }
                else if (laundryMatch.Success)
                {
                    string laundryAsString = laundryMatch.ToString();
                    string numPattern = @"\d";

                    MatchCollection nums = Regex.Matches(laundryAsString, numPattern);

                    foreach (var match in nums)
                    {
                        int num = int.Parse(match.ToString());
                        timeLaundry += num;
                    }
                }
                input = Console.ReadLine();
            }
            totalMinutes = timeDishes + timeCleaning + timeLaundry;
            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {totalMinutes} min.");
        }
    }
}
