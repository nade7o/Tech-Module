using System;

namespace _12.SantaCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalBoxes = 0;

            for (int i = 0; i < n; i++)
            {
                int flourAmount = int.Parse(Console.ReadLine());
                int sugarAmount = int.Parse(Console.ReadLine());
                int cocoaAmount = int.Parse(Console.ReadLine());
                
                int flourCups = flourAmount / 140;
                int sugarSpoons = sugarAmount / 20;
                int cocoaSpoons = cocoaAmount / 10;
                int boxesOfCookies = 0;

                if (flourCups > 0 && sugarSpoons > 0 && cocoaSpoons > 0)
                {
                    int totalCookiesPerBake = (140 + 10 + 20) * Math.Min((Math.Min(flourCups, sugarSpoons)), cocoaSpoons) / 25;
                    boxesOfCookies = totalCookiesPerBake / 5;
                    Console.WriteLine($"Boxes of cookies: {boxesOfCookies}");
                    totalBoxes += boxesOfCookies;
                }
                else 
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
            }
            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
