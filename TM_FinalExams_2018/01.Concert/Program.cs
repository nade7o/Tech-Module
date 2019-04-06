using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> bandInfo = new Dictionary<string, List<string>>();
            //key = name of band;  value = list of members

            Dictionary<string, int> time = new Dictionary<string, int>();
            // key = name of band;  value = the band time on the stage

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] tokens = input.Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                string action = tokens[0];
                string bandName = tokens[1];

                if (!bandInfo.ContainsKey(bandName) && !time.ContainsKey(bandName))
                {
                    bandInfo.Add(bandName, new List<string>());
                    time.Add(bandName, 0);
                }
                if (action == "Add")
                {
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        string singer = tokens[i];
                        if (!bandInfo[bandName].Contains(singer))
                        {
                            bandInfo[bandName].Add(singer);
                        }
                    }
                }
                else if (action == "Play")
                {
                    int timeForABand = int.Parse(tokens[2]);
                    time[bandName] += timeForABand;
                }
            }
            int totalTime = time.Values.Sum();
            Console.WriteLine($"Total time: {totalTime}");

            //At the end you have to print the total time and the bands ordered by the time on stage in descending order, 
            //then by band name in ascending order.
            foreach (var band in time.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }
            input = Console.ReadLine();
            foreach (var band in bandInfo.Where(x => x.Key.Equals(input)))
            {
                Console.WriteLine(band.Key);
                Console.WriteLine(string.Join(Environment.NewLine, band.Value.Select(x => $"=> {x}")));
            }
        }
    }
}
