using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] token = Console.ReadLine().Split();
                if (token[0] == "end")
                {
                    break;
                }
                else if (token[0] == "Delete")
                {
                    int numberToRemove = int.Parse(token[1]);
                    list.RemoveAll(x => x == numberToRemove);
                }
                else if (token[0] == "Insert")
                {
                    list.Insert(int.Parse(token[2]), int.Parse(token[1]));
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
