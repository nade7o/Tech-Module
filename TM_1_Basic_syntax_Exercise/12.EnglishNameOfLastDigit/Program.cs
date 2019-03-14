using System;

namespace _12.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            GetTheLastDigit(lastDigit);
        }
       static void GetTheLastDigit(int lastDigit)
        {
            string text = "";
            if (lastDigit == 0)
            {
                text = "zero";
            }
            else if (lastDigit == 1)
            {
                text = "one";
            }
            else if (lastDigit == 2)
            {
                text = "two";
            }
            else if (lastDigit == 3)
            {
                text = "three";
            }
            else if (lastDigit == 4)
            {
                text = "four";
            }
            else if (lastDigit == 5)
            {
                text = "five";
            }
            else if (lastDigit == 6)
            {
                text = "six";
            }
            else if (lastDigit == 7)
            {
                text = "seven";
            }
            else if (lastDigit == 8)
            {
                text = "eight";
            }
            else if (lastDigit == 9)
            {
                text = "nine";
            }
            Console.WriteLine(text);
        }
}
    
}

