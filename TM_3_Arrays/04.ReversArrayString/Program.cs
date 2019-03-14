using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        string[] text = Console.ReadLine().Split().ToArray();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i] + " ");
        }
    }
}