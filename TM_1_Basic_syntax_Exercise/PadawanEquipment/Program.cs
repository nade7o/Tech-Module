using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOwned = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            
            int lightsaberCount = (int) Math.Ceiling(1.10 * students);
            //Нарича се Ternary (shorthand for if-then-else statement) 
            //Integer beltCount;
            //If(studentCount == 0) 
            //{
            //    beltCount = 0;
            //} 
            //else 
            //{
            //    beltCount = studentCount - (student / 6);
            //}
            //Или обяснено по следният начин: променлива = (някакво услови)  ? изпълни тази част ако условието е вярно: изпълни тази част ако условието е грешно;
            //Задължително е винаги частите да са две и да могат да се побират в променливата т.е.ако променливата е итеджър двете части трябва да връщат интеджър;
            //А самото деление на 6 го правя за да видя колко пъти има група от по 6 студента за да знам колко колана да махна.
            int beltCount = (students == 0) ? 0 : students - (students / 6);
            int robeCount = students;
            
            

            double totalEquipmentCost = (lightsaberCount * lightsabersPrice) + (robeCount * robesPrice) + (beltCount * beltsPrice);

            if (totalEquipmentCost <= moneyOwned)
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentCost:f2}lv.");
            }
            else 
            {
                double moneyNeeded = totalEquipmentCost - moneyOwned;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}

