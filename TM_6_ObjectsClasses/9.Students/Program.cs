using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> listStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                var student = new Student(firstName, lastName, grade);
                listStudents.Add(student);
            }
            listStudents = listStudents.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in listStudents)
            {
                Console.WriteLine("{0} {1}: {2:f2}", student.FirstName, student.LastName, student.Grade);
            }
        }
    }
}
