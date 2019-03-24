using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsAsString = Console.ReadLine();
            string[] wordsToRemove = wordsAsString.Split(", ");
            string text = Console.ReadLine();
            foreach (var wordToRemove in wordsToRemove)
            {
                string newString = "";
                for (int i = 0; i < wordToRemove.Length; i++)
                {
                    newString += '*';
                }
                if (text.Contains(wordToRemove))
                {
                    int asterics = wordToRemove.Length;
                    text = text.Replace(wordToRemove, newString);
                }
            }
            Console.WriteLine(text);
        }
    }
}
