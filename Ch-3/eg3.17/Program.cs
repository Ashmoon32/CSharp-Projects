using System;
using System.IO;

namespace FileHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\AshMoon\\sample.txt";

            StreamWriter Writer = new StreamWriter(path);
            Writer.WriteLine(Console.ReadLine());
            Writer.WriteLine("This file is created by using StreamWriter!");
            Writer.Close();

            Console.WriteLine("File created and data wrote successfully!");

            StreamReader Reader = new StreamReader(path);
            string content = Reader.ReadToEnd();
            Reader.Close();

            Console.WriteLine("Contents of the file: ");
            Console.WriteLine(content);
        }
    }
}
