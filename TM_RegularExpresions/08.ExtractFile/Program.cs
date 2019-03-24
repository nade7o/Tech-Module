﻿using System;

namespace _08.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int startIndexOfFile = path.LastIndexOf('\\')+1;
            string file = path.Substring(startIndexOfFile);

            int startIndexOfExtension = file.LastIndexOf('.') + 1;
            string fileName = file.Substring(0, startIndexOfExtension - 1);
            string extensionName = file.Substring(startIndexOfExtension);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionName}");
        }
    }
}
