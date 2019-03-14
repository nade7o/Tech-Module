using System;
using System.Collections.Generic;
using System.Linq;
namespace _5.BombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombList[0];
            int power = bombList[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                if (currentNum == bomb)
                {
                    int startIndex = i - power; 
                    int endIndex = i + power;  
                    //валидация на индексите
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    if (startIndex > numbers.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }
                    //изгорелите бомбички
                    numbers.RemoveRange(startIndex, endIndex - startIndex +1);//startIndex-endIndex+1 -> изчислява колко числа след starindexa ще гръмнат. +1 -> за да хване и посления индекс
                    i = startIndex - 1; //трябва всеки път да проверяваме от предходния старт индекс
                }
            }
            //извеждане на изхода от програмата
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
