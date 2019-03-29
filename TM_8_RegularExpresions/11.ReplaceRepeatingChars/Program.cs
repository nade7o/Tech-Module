using System;

namespace _11.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                if (i != text.Length-1)
                {
                    char nextLetter = text[i + 1];
                    if (currentLetter != nextLetter)
                    {
                        result += currentLetter;
                    }
                }
                else
                {
                    result += currentLetter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
