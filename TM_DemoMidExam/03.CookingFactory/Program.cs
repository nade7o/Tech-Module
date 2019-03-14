using System;
using System.Linq;
using System.Collections.Generic;
namespace _3.CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestTotalQuality = -10000; 
            double bestAverage = 0;
            string bestLine = "";
            int bestLength = int.MaxValue;
            int totalCurrentQuality = 0;
            int currentLength = 0;
            double currentAverage = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Bake It!")
                {
                    break;
                }
                int[] qualitiesOfCurrentBread = line.Split('#').Select(int.Parse).ToArray();
                totalCurrentQuality = 0;
                currentLength = qualitiesOfCurrentBread.Length;

                // 5#3#2           total: 10; average:3; lenght:3 --> best element
                //10#2#-2#1#-1      total: 10; average:2; lenght:5
                //4#2#1             total:7; average: 2; lenght: 3
                //Bake It!

                for (int i = 0; i < qualitiesOfCurrentBread.Length; i++)
                {
                    totalCurrentQuality += qualitiesOfCurrentBread[i];
                }

                currentAverage = totalCurrentQuality / (qualitiesOfCurrentBread.Length);

                if (totalCurrentQuality > bestTotalQuality)
                {
                    bestTotalQuality = totalCurrentQuality;
                    bestAverage = currentAverage;
                    bestLine = line;
                    bestLength = currentLength; 
                }
                else if (totalCurrentQuality == bestTotalQuality && currentAverage > bestAverage)
                {
                    bestAverage = currentAverage;
                    bestTotalQuality = totalCurrentQuality;
                    bestLine = line;
                    bestLength = currentLength;
                }
                else if ((totalCurrentQuality == bestTotalQuality) && (currentAverage == bestAverage))
                {
                    if (currentLength < bestLength)
                    {
                        bestTotalQuality = totalCurrentQuality;
                        bestLine = line;
                        bestLength = currentLength;
                    }
                }
            }
            Console.WriteLine($"Best Batch quality: {bestTotalQuality}");
            Console.WriteLine(bestLine.Replace("#", " "));
        }
    }
}