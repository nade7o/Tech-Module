using System;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(text, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string text, int count)
        {
            string repeatedStr = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedStr += text;
            }
            return repeatedStr;
        }
    }
}
