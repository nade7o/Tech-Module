using System;
using System.Text.RegularExpressions;

namespace _02.Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string[] secondLine = Console.ReadLine().Split();
            string firstSubstring = secondLine[0];
            string secondSubstring = secondLine[1];
            string decodedString = "";
            

            string pattern = @"^[d-z#|{}\s]+$";
            //A valid text contains only lowercase letters, from 'd' onwards, and the symbols '{', '}', '|', '#'
            var matches = Regex.Match(firstLine, pattern);
            if (matches.Success)
            {
                    for (int i = 0; i < firstLine.Length; i++)
                    {
                        int currentCharNum = firstLine[i] - 3;
                        char currentChar = (char)(currentCharNum);
                        decodedString += currentChar;
                    }

                    string dec = decodedString.Replace(firstSubstring, secondSubstring);
                    Console.WriteLine(dec);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
