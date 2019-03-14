using System;

namespace _10.rageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            

            int headsetTimesTrash = (lostGamesCount == 0) ? 0 : (lostGamesCount / 2);
            int mouseTimesTrash = (lostGamesCount == 0) ? 0 :  (lostGamesCount / 3);
            int keyboardTimesTrash = (lostGamesCount == 0) ? 0 : (lostGamesCount / 6);
            int displayTimesTrash = (keyboardTimesTrash == 0) ? 0 : (keyboardTimesTrash / 2);

            double totalCostTrashes = (headsetTimesTrash * headsetPrice) + (mouseTimesTrash * mousePrice) + (keyboardTimesTrash * keyboardPrice) + (displayTimesTrash * displayPrice);
            Console.WriteLine($"Rage expenses: {totalCostTrashes:f2} lv.");


        }
    }
}
