using System;
using System.Collections.Generic;
using System.Linq;
namespace _5.Students
{

    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student();
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                };
                students.Add(student);

                line = Console.ReadLine();
            }
            string filterCity = Console.ReadLine();
            foreach (Student student in students)
            {
             if (student.City == filterCity)
            {
              Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
            }
            //filter the students with LINQ.
           // List<Student> filteredStudents = students.Where(s => s.City == filterCity).ToList();
           // foreach (var student in filteredStudents)
           // {
           //     Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
           // }

        }
    }
}
