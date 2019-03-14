using System;
using System.Collections.Generic;
using System.Linq;
namespace _09.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            List<int> houses = Console.ReadLine().Split('@').Select(x => int.Parse(x)).ToList();
            int santaIndex = 0;

            while ((line = Console.ReadLine())!= "Merry Xmas!")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                int jumpLength = int.Parse(tokens[1]);

                if (santaIndex + jumpLength >= houses.Count)
                {
                    //If Santa jumps outside of the fiel size , he should start from index 0;
                    santaIndex = (santaIndex + jumpLength) % houses.Count;
                }
                else
                {
                    santaIndex += jumpLength;
                }
                if (houses[santaIndex] == 0)
                {
                    Console.WriteLine($"House {santaIndex} will have a Merry Christmas.");
                }
                else
                {
                    houses[santaIndex] -= 2;
                }
                
            }
            int failedHouses = houses.Where(x => x != 0).Count();

            Console.WriteLine($"Santa's last position was {santaIndex}.");

            if (failedHouses > 0)
            {
             // If the count of all houses that won't have a Merry Christmas, print this:
            Console.WriteLine($"Santa has failed {failedHouses} houses.");
            }
            else
            {
              //If all members of each house have presents print this:
                Console.WriteLine("Mission was successful.");
            }

        }
    }
}
