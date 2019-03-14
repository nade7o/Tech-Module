using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            rotations = rotations % numbers.Length;

            for (int i = 0; i < rotations; i++)
            {
                string element = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = element;
            }
            foreach (string number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
