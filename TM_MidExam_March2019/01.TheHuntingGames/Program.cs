using System;

namespace _1.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double currentGroupEnergy = double.Parse(Console.ReadLine());
            double waterForOnePerson = double.Parse(Console.ReadLine());
            double foodForOnePerson = double.Parse(Console.ReadLine());

            double currentGroupWater = waterForOnePerson * players * days;
            double currentGroupFood = foodForOnePerson * players * days;



            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                currentGroupEnergy -= energyLoss;

                if (currentGroupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {currentGroupFood:f2} food and {currentGroupWater:f2} water.");
                    return;
                }

                if (i % 2 == 0)
                {
                    currentGroupEnergy = currentGroupEnergy + (currentGroupEnergy * 0.05);
                    currentGroupWater = currentGroupWater - (currentGroupWater * 0.3);
                }
                if (i % 3 == 0)
                {
                    //currentGroupFood = (players == 0) ? 0 : currentGroupFood / players;
                    currentGroupFood -= (currentGroupFood / players); 

                    currentGroupEnergy = currentGroupEnergy + (currentGroupEnergy * 0.1);
                }
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {currentGroupEnergy:f2} energy!");
        }
    }
}
