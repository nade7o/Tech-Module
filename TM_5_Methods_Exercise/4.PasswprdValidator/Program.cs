using System;

namespace _4.PasswprdValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isBetweenSixAndTenChars = StringLEnghtChecker(password);
            bool isOnlyLettersAndDigits = StringCharChecker(password);
            bool haveAtLeastTwoDigits = DigitCountCheker(password);

            if (!isBetweenSixAndTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isBetweenSixAndTenChars && isOnlyLettersAndDigits && haveAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitCountCheker(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool StringCharChecker(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool StringLEnghtChecker(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private static void ValidatePassword(string password)
        //{
        //    int countChars = 0;
        //    for (char i = password[0]; i < password.Length; i++)
        //    {
        //        char letter = password[i];
        //        countChars++;
        //        int countDigits = 0;
        //        if (countChars < 6 && countChars > 10)
        //        {
        //            Console.WriteLine("Password must be between 6 and 10 characters");
        //        }
        //        else if (!char.IsLetter(letter) || !char.IsDigit(letter))
        //        {
        //            Console.WriteLine("Password must consist only of letters and digits");
        //        }
        //        else if (char.IsDigit(letter))
        //        {
        //            countDigits++;
        //            if (countDigits < 2)
        //            {
        //                Console.WriteLine("Password must have at least 2 digits");
        //            }
        //        }
        //    }
    }
    }

