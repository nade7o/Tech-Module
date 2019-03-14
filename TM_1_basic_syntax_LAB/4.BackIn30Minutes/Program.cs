using System;

namespace _4.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNow = int.Parse(Console.ReadLine());
            int minsNow = int.Parse(Console.ReadLine());

            int mins = minsNow + 30;

            if (mins > 59)
            {
                hoursNow++;
                mins -= 60;
            }
            if (hoursNow > 23)
            {
                hoursNow = 0;
                
            }
            if (mins < 10)
            {
                Console.WriteLine($"{hoursNow}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{hoursNow}:{mins}");
            }
            
        }
    }
}
