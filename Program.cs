using System;
using System.Diagnostics;
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
                        Methods.DecisionChoise(key, strings);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        string[] strings = Methods.UserInput();
                        Text.SelectOption();
                        key = Console.ReadKey();
                        Console.Beep();
                        Methods.DecisionChoise(key, strings);
                        break;
                    }
                default: Main(); break;
            }
        }
    }
}