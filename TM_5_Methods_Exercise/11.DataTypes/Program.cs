using System;

namespace _11.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            OperationsWithTypes(type);
        }

        private static void OperationsWithTypes(string type)
        {
            if (type == "int")
            {
                int numer = int.Parse(Console.ReadLine());
                int result = numer * 2;
                Console.WriteLine(result);
            }
            else if (type == "real")
            {
                double number = double.Parse(Console.ReadLine());
                double result = number * 1.5;
                Console.WriteLine($"{result:f2}");
            }
            else if (type == "string")
            {
                string result = Console.ReadLine();
                Console.WriteLine($"${result}$");
            }
        }
    }
}
