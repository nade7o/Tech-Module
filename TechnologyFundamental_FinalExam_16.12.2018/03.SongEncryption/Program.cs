using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            //Artist – starts with capital letter, followed by lowercase letters,
            //It can also contains apostrophe ( ' ), and whitespace " ";
            string artistPattern = @"^(?<artist>[A-Z][a-z ']*)$";

            //Song – contains only capital letters, and whitespaces;
            string songPattern = @"^(?<song>[A-Z ]+)$";


            string keepPatern = @"[^' @]";

            string input = Console.ReadLine();

            while (input != "end")
            {

                string[] tokens = input.Split(":");
                string artist = tokens[0];
                string song = tokens[1];

                bool artistIsValid = Regex.IsMatch(artist, artistPattern);
                bool songIsValid = Regex.IsMatch(song, songPattern);

                if (!artistIsValid || !songIsValid)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (artistIsValid && songIsValid)
                {
                    //Regex.Match > returns the specified input string or the first occurence;

                    Match artistMatch = Regex.Match(artist, artistPattern); // matches the artist
                    Match songMatch = Regex.Match(song, songPattern);      // matches the song

                    StringBuilder sb = new StringBuilder();
                    int length = artist.Length;
                    string text = $"{artistMatch.Groups["artist"].Value}@{songMatch.Groups["song"].Value}";

                    foreach (char symbol in text)
                    {
                        char currentSymbol = symbol;
                        bool isValidSymbol = Regex.IsMatch(currentSymbol.ToString(), keepPatern);

                        if (isValidSymbol)
                        {
                            currentSymbol =(char) (currentSymbol + length);

                            if (symbol <= 90 && currentSymbol>90)
                            {
                                currentSymbol -= (char)26;
                            }
                            else if (symbol <= 122 && currentSymbol > 122)
                            {
                                currentSymbol -= (char)26;
                            }
                        }
                        sb.Append(currentSymbol);
                    }
                    Console.WriteLine($"Successful encryption: {sb}");
                }
                input = Console.ReadLine();
            }
        }
    }
}
