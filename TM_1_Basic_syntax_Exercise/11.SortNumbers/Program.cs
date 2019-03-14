using System;

namespace _11.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
            {          
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
