using System;

namespace _14ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] array = word.ToCharArray();
            string reverse = string.Empty;

            for (int i = array.Length - 1; i > -1; i--)
            {
                reverse += array[i];
            }
            foreach (var item in reverse)
            {
                Console.Write(item);
            }
        }
    }
}
