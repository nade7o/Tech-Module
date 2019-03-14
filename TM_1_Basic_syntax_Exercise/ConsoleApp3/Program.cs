using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelts = 0;
            int lightsaberOdd = (int)Math.Ceiling(students * 0.10);

            if (students >= 6)
            {
                for (int i = 1; i <= students ; i += 6)
                {
                    freeBelts++;
                }
            }
            double totalEquipmentCost = ((students + lightsaberOdd) * lightsaberPrice) + (students * robePrice) + ((students - freeBelts) * beltPrice);

            if (totalEquipmentCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentCost:f2}lv.");
            }
            else
            {
                double moneyNeeded = totalEquipmentCost - money;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
