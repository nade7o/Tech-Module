using System;
using System.Collections.Generic;

namespace _2ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split("&");

            List<string> keys = new List<string>();

            
            foreach (var key in line)
            {
                if (key.Length == 16 || key.Length == 25)
                {
                    bool isValid = true;

                    foreach (var symbol in key)
                    {
                        if (!char.IsLetterOrDigit(symbol))
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        keys.Add(key);
                    }
                }
            }
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].Length == 16)
                {
                    keys[i] = keys[i].Insert(4, "-");
                    keys[i] = keys[i].Insert(9, "-");
                    keys[i] = keys[i].Insert(14, "-");
                }
                else if (keys[i].Length == 25)
                {
                    keys[i] = keys[i].Insert(5, "-");
                    keys[i] = keys[i].Insert(11, "-");
                    keys[i] = keys[i].Insert(17, "-");
                    keys[i] = keys[i].Insert(23, "-");
                }
            }
            for (int i = 0; i < keys.Count; i++)
            {
                for (int j = 0; j < keys[i].Length; j++)
                {
                    char currentChar = keys[i][j];
                    if (char.IsDigit(currentChar))
                    {
                        int currentDigit = 9 - int.Parse(currentChar.ToString());
                        keys[i] = keys[i].Remove(j,1);
                        keys[i] = keys[i].Insert(j, currentDigit.ToString());
                    }
                }
                keys[i] = keys[i].ToUpper();
            }
            Console.WriteLine(string.Join(", ", keys));

        }
    }
}
