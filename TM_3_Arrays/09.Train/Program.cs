using System;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];

            }
            for (int i = 0; i < passengers.Length; i++)
            {
                Console.Write(passengers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
