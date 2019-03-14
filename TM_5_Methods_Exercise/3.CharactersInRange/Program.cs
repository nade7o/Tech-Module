using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char charStart = char.Parse(Console.ReadLine());
            char charFinal = char.Parse(Console.ReadLine());
            PrintCharsInRange(charStart, charFinal);
        }

        private static void PrintCharsInRange(char charFirst, char charSecond)
        {
            
            if (charFirst < charSecond)
            {
                for (char i = (char) (charFirst + 1); i < charSecond; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else if (charFirst > charSecond)
            {
                for (char i = (char)(charSecond + 1); i < charFirst; i++)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
