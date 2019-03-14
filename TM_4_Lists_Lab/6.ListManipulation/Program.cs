using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            while (true)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();
                if (command[0] == "end")
                {
                   break;
                }
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
               else if (command[0] == "Insert")
                {
                    int numberToinsert = int.Parse(command[1]);
                    int indexToInsert = int.Parse(command[2]);
                    numbers.Insert(indexToInsert, numberToinsert);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
