using System;

namespace _05.DigitLettersOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =  Console.ReadLine();
            string digits = "";
            string letters = "";
            string others = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits += text[i];
                }
                if (char.IsLetter(text[i]))
                {
                    letters += text[i];
                }
                if (!char.IsLetterOrDigit(text[i]))
                {
                    others += text[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
