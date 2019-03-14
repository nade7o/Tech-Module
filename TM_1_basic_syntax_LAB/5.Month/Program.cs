using System;

namespace _5.Month
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
            if (number > 0 && number <= 12)
            {
                Console.WriteLine(months[number - 1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }

            
        }
    }
}
