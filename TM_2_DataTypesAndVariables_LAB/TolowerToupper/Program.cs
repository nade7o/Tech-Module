using System;

namespace TolowerToupper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 'A'; i <= 'Z'; i++)
            {
                if (symbol == i)
                {
                    Console.WriteLine("upper-case");
                }
            }
            for (int i = 'a'; i <= 'z' ; i++)
            {
                if (symbol == i)
                {
                    Console.WriteLine("lower-case");
                }
            }
        }
    }
}
