using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;
            int times = 0;
            char[] usernameRev = username.ToCharArray();
            string reverse = string.Empty;
            for (int i = usernameRev.Length - 1; i > -1; i--)
            {
                reverse += usernameRev[i];
            }

            while (times < 4)
            {
                pass = Console.ReadLine();
                times++;
                if (times >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                if (pass == reverse)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
