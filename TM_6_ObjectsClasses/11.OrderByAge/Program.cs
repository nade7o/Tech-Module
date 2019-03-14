using System;
using System.Collections.Generic;
using System.Linq;
namespace _7.OrderByAge
{
    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<People> listPeople = new List<People>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    listPeople = listPeople.OrderBy(x => x.Age).ToList();
                    foreach (var item in listPeople)
                    {
                        Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
                    }
                    break;
                }
                string[] tokens = command.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                var person = new People(name, id, age);
                listPeople.Add(person);
            }
        }
    }
}
