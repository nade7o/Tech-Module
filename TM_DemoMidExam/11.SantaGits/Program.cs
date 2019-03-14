using System;
using System.Collections.Generic;
using System.Linq;
namespace _11.SantaGits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currentindex = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                
                if (command == "Forward")
                {
                    int numberOfSteps = int.Parse(input[1]);
                    if (currentindex + numberOfSteps < houses.Count)
                    {
                        currentindex += numberOfSteps;
                        houses.RemoveAt(currentindex);
                    }
                    
                }
                else if (command == "Back")
                {
                    int numberOfSteps = int.Parse(input[1]);

                    if (currentindex - numberOfSteps >= 0)
                    {
                        currentindex -= numberOfSteps;
                        houses.RemoveAt(currentindex);
                    }
                    
                }
                else if (command == "Gift")
                {
                    int index =int.Parse(input[1]);

                    if (index >= 0 && index < houses.Count)
                    {
                        int houseNumber = int.Parse(input[2]);
                        houses.Insert(index, houseNumber);
                        currentindex = index;
                    }
                }

                else if (command == "Swap")
                {
                    int numberFirst = int.Parse(input[1]);
                    int numberSecond = int.Parse(input[2]);

                    if (houses.Contains(numberFirst) && houses.Contains(numberSecond))
                    {
                        int indexFirst = houses.IndexOf(numberFirst);
                        int indexSecond = houses.IndexOf(numberSecond);

                        int changetNumber = houses[indexFirst];
                        houses[indexFirst] = houses[indexSecond];
                        houses[indexSecond] = changetNumber;
                        //houses.Insert(indexFirst, numberSecond);
                       // houses.RemoveAt(indexFirst + 1);
                       // houses.Insert(indexSecond, numberFirst);
                        //houses.RemoveAt(indexSecond + 1);
                    }
                }
            }
            Console.WriteLine($"Position: {currentindex}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
