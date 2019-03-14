using System;

namespace _1.SpringVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            double foodExpensesPerPerson = double.Parse(Console.ReadLine());
            double roomPriceForOne = double.Parse(Console.ReadLine());

            double foodExpenses = foodExpensesPerPerson * people * days;
            double hotelExpenses = roomPriceForOne * people * days;
            double currentExpenses = foodExpenses + hotelExpenses;

            if (people >= 10)
            {
                hotelExpenses *= 1.25;
            }

            

            for (int i = 1; i <= days; i++)
            {
                double distance = double.Parse(Console.ReadLine());
                double fuelExpensesPerDay = distance * fuelPrice;
                currentExpenses += fuelExpensesPerDay;
                if (budget < currentExpenses)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpenses-budget):f2}$ more.");
                    break;
                }

                if (i % 3 == 0 || i % 5 == 0)
                {
                   currentExpenses *= 1.4;
                    if (budget < currentExpenses)
                    {
                        Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpenses-budget):f2}$ more.");
                        
                        break;
                    }

                }
                if (i % 7 == 0)
                {
                    double receivedMoney = currentExpenses / people;
                    currentExpenses -= receivedMoney;
                }
            }
            if (budget >= currentExpenses)
            {
                double moneyLeft = budget - currentExpenses;
                Console.WriteLine($"You have reached the destination. You have {moneyLeft:f2}$ budget left.");
            }
            
        }
    }
}
