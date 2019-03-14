using System;
using System.Linq;
using System.Collections.Generic;
namespace _5.GuestJurnal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();
            string command;
            while ((command = Console.ReadLine()) != "Retire!")
            {
                string[] commands = command.Split(" - ").ToArray();
                string currentCommand = commands[0];
                string name = commands[1];

                if (currentCommand == "Start")
                {

                    if (!journal.Contains(name))
                    {
                        journal.Add(name);
                    }
                }
                else if (currentCommand == "Complete")
                {
                    if (journal.Contains(name))
                    {
                        journal.Remove(name);
                    }
                }
                //"Side Quest - {quest}:{sideQuest}"
                else if (currentCommand == "Side Quest")
                {
                    List<string> listOfSideQuest = name.Split(":").ToList();
                    string guest = listOfSideQuest[0];
                    string sideguest = listOfSideQuest[1];

                    if (journal.Contains(guest))
                    {
                        int indexGuest = journal.IndexOf(guest);
                        if (!journal.Contains(sideguest))
                        {
                            journal.Insert(indexGuest + 1, sideguest);
                        }
                    }
                }
                else if (currentCommand == "Renew")
                {
                    if (journal.Contains(name))
                    {
                        journal.Remove(name);
                        journal.Add(name);

                    }
                }
            }
            Console.Write(string.Join(", ", journal));

        }
    }
}
