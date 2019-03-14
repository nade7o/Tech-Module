using System;

namespace _6.strongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            int sum = 0;

            for (int i = number; i > 0 ; i = i / 10)
            {
                result = 1;
                for (int j = 1; j <= i % 10; j++)
                {
                    result *= j;
                }
                sum += result;
            }

            
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
