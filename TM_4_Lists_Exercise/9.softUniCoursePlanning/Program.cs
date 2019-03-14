using System;
using System.Collections.Generic;
using System.Linq;
namespace _9.softUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "course start")
                {
                    break;
                }
                string[] tokens = command.Split(":");

                if (tokens[0] == "Add")
                {
                    string lessonTitle = tokens[1];
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    string lessonTitle = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    string lessonTitle = tokens[1];
                    if (lessons.Contains(lessonTitle))
                    {
                        //Check if lesson has Exercise to Remove.
                        int index = lessons.IndexOf(lessonTitle);
                        if (lessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            lessons.RemoveAt(index + 1); //If has Exercise- remove it.
                        }
                        lessons.Remove(lessonTitle);
                    }
                }
                else if (tokens[0] == "Swap")
                {
                    string lessonTitle1 = tokens[1];
                    string lessonTitle2 = tokens[2];
                    int index1 = lessons.IndexOf(lessonTitle1);
                    int index2 = lessons.IndexOf(lessonTitle2);

                    if (index1 == -1 || index2 == -1)
                    {
                        continue;
                    }
                    // Swap the two lessons.
                    else
                    {
                        lessons[index1] = lessonTitle2;
                        lessons[index2] = lessonTitle1;

                        //Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.
                        if (lessons.Contains($"{lessonTitle1}-Exercise"))
                        {
                            string lessonFirstExercise = lessons[index1 + 1];
                            lessons.RemoveAt(index1 + 1);
                            lessons.Insert(index2 + 1, lessonFirstExercise); // на индекса на втория урок - слагаме първия урок.
                        }
                        if (lessons.Contains($"{lessonTitle2}-Exercise"))
                        {
                            string lessonSecondExercise = lessons[index2 + 1];
                            lessons.RemoveAt(index2 + 1);
                            lessons.Insert(index1 + 1, lessonSecondExercise); // на индекса на първия урок - слагаме първия урок.
                        }
                    }
                }
                else if (tokens[0] == "Exercise")
                {
                    string lessonTitle = tokens[1];
                    string exercise = $"{lessonTitle}-Exercise";
                    //If the lesson doesn`t exist - add the lesson in the end, followed by the Exercise.
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exercise);
                    }
                    //If the lesson exist but there is no exercise already - add the Exercise
                    if (lessons.Contains(lessonTitle) && !lessons.Contains(exercise))
                    {
                        int index = lessons.IndexOf(lessonTitle);
                        lessons.Insert(index + 1, exercise);
                    }
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
