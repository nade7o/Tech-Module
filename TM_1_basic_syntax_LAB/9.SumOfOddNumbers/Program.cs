using System;

namespace _9.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
           
            for (int i = 1; i <= counter; i+=2)
            {
                counter++;
                Console.WriteLine(i);
                sum += i;
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
