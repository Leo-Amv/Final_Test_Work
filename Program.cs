using System;
using System.Diagnostics;
using System.Threading;
namespace FinalTestWork
{
    class Program
    {
        public static void Main()
        {
            Text.Menu();
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Beep();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        Text.ArrayExamples();
                        key = Console.ReadKey();
                        Console.Beep();
                        string[] strings = Methods.ReadyArray(key);
                        Text.SelectOption();
                        key = Console.ReadKey();
                        Console.Beep();
                        Solutions.SolutionChoise(key, strings);
                        for (int i = 1; i <= 11; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(0, 11);
                            Console.WriteLine($"\nTHE PROGRAM WILL CLOSE IN : {11 - i} SECONDS ");
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                        }
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        string[] strings = Methods.UserInput();
                        Text.SelectOption();
                        key = Console.ReadKey();
                        Console.Beep();
                        Solutions.SolutionChoise(key, strings);
                        for (int i = 1; i <= 11; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(0, 11);
                            Console.WriteLine($"\nTHE PROGRAM WILL CLOSE IN : {11 - i} SECONDS ");
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                        }
                        break;
                    }
                default: Main(); break;
            }
        }
    }
}
