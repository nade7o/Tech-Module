using System;

namespace _9.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            ChekIfNumerIsPalindrome(input);
        }


            private static void ChekIfNumerIsPalindrome(string input)
        {
            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                bool isPalindrome = false;

                //reverse string
                char[] inputArray = input.ToCharArray();
                Array.Reverse(inputArray);
                string second = new string(inputArray);
                
                if (input.Equals(second))
                {
                    isPalindrome = true;
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
