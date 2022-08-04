using System;
namespace FinalTestWork
{
    class Program
    {
        public static void Main()
        {
            Text.Menu();
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Beep();
            if (key.Key == ConsoleKey.D1)
            {
                Text.ArrayExamples();
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    string[] strings = { "hello", "2", "world", ":-)" };
                    Methods.ArrayFormation1(strings);
                    Console.WriteLine($"\n{string.Join(" ", Methods.ArrayFormation1(strings))}");
                    Console.WriteLine(Methods.ArrayFormation1(strings).Length);
                }
                if (key.Key == ConsoleKey.D2)
                {
                    string[] strings = { "1234", "1567", "-2", "computer science" };
                    Methods.ArrayFormation1(strings);
                    Console.WriteLine($"\n{string.Join(" ", Methods.ArrayFormation1(strings))}");
                    Console.WriteLine(Methods.ArrayFormation1(strings).Length);
                }
                if (key.Key == ConsoleKey.D3)
                {
                    string[] strings = { "Russia", "Denmark", "Kazan" };
                }
            }
        }
    }
}