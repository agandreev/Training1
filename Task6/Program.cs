using System;
using System.Collections.Generic;
using System.Linq;
using FileLib;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            const string path = @"../../Program.cs";
            do
            {
                foreach (string line in new FileLines(path))
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine();

                foreach (string line in new FileLine2(path))
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine();

                foreach (string line in new FileLinesArr(path))
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("Введите ESC, чтобы работу...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
