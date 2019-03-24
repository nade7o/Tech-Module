using System;

namespace _12.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                if (currentSymbol == '>')
                {
                    int currentPower = int.Parse(text[i + 1].ToString());
                    power += currentPower;
                }
                else if (char.IsLetterOrDigit(currentSymbol) && power > 0)
                {
                    text = text.Remove(i, 1);
                    power--;
                    i--;
                }
            }
            Console.WriteLine(text);
        }
    }
}
