using System;

namespace _9.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "string": 
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    string resultStr = GetMaxString(string1, string2);
                    Console.WriteLine(resultStr);
                    break;
                case "char":
                    char character1 = char.Parse(Console.ReadLine());
                    char character2 = char.Parse(Console.ReadLine());
                    char resultChar = GetMaxChar(character1, character2);
                    Console.WriteLine(resultChar);
                    break;
                case "int":
                    int value1 = int.Parse(Console.ReadLine());
                    int value2 = int.Parse(Console.ReadLine());
                    int resultInt = Math.Max(value1, value2);
                    Console.WriteLine(resultInt);
                    break;
            }
        }

        private static int GetMaxInt(int value1, int value2)
        {

            int result = Math.Max(value1, value2);
            return result;
        }

        private static char GetMaxChar(char value1, char value2)
        {
            return (char) Math.Max(value1, value2);
            
        }

        private static string GetMaxString(string value1, string value2)
        {
            int comparison = value1.CompareTo(value2);

            if (comparison > 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
    }
}
