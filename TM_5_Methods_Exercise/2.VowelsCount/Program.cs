using System;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(CountVowes(text)); 
        }

        private static int CountVowes(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                
                switch (letter)
                {
                    case 'a':
                    case 'A':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I': count++; break;
                }
            }
            return count;
        }
    }
}
