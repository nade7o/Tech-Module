using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float km = meters / 1000f;
            Console.WriteLine($"{km:f2}");
        }
    }
}
