using System;

namespace _1.CookingMasterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int apronCount = (int)Math.Ceiling(students * 1.20);
            int flourCount = (students == 0) ? 0 : students - (students / 5);

            double sum = apronPrice * apronCount + (students * eggPrice * 10) + flourPrice * flourCount;

            if (sum <= budget)
            {
                Console.WriteLine($"Items purchased for {sum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(sum - budget):f2}$ more needed.");
            }

        }
    }
}
