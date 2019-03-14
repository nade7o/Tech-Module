using System;
using System.Collections.Generic;
namespace _4.ListProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> produstList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                produstList.Add(product);
            }
            produstList.Sort();
            for (int i = 0; i < produstList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{produstList[i]}");
            }
        }
    }
}
