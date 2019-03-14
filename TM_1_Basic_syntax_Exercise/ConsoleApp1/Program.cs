using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day == "Friday" )
            {
                switch (type)
                {
                    case "Students": price = 8.45; break;
                    case "Business": price = 10.90; break;
                    case "Regular": price = 15.0; break;
                }
            }
            else if (day == "Saturday")
            {
                switch (type)
                {
                    case "Students": price = 9.80; break;
                    case "Business": price = 15.60; break;
                    case "Regular": price = 20.0; break;
                }
            }
            else if (day == "Sunday")
            {
                switch (type)
                {
                    case "Students": price = 10.46; break;
                    case "Business": price = 16.0; break;
                    case "Regular": price = 22.50; break;
                }
            }
            double totalPrice = people * price;
            double discount = 0;
            if (type == "Students" && people >= 30)
            {
                discount = 0.15;
            }
            else if (type == "Business" && people >= 100)
            {
                people -= 10;
                totalPrice = people * price;
            }
            else if (type == "Regular" && people >= 10 && people <= 20)
            {
                discount = 0.05;
            }
            double finalPrice = totalPrice - (totalPrice * discount);
            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
