using System;
using System.Text.RegularExpressions;

namespace _1.ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;

            string patern = @"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>\d+)<<(?<code>.+)$";

            while ((line = Console.ReadLine()) != "Last note")
            {
                if (Regex.Match(line, patern).Success)
                {
                    foreach (Match item in Regex.Matches(line, patern))
                    {
                        string name = string.Empty;
                        int length = int.Parse(item.Groups["length"].Value);
                        string code = item.Groups["code"].Value;
                        if (length == code.Length)
                        {
                            foreach (var i in item.Groups["name"].Value)
                            {
                                if (char.IsLetterOrDigit(i))
                                {
                                    name += i;
                                }
                            }
                            Console.WriteLine($"Coordinates found! {name} -> {code}");
                        }
                        else
                        {
                            Console.WriteLine("Nothing found!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
