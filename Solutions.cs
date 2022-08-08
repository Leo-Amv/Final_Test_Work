using System.Diagnostics;
namespace FinalTestWork
{
    class Solutions
    {
        private static Stopwatch time = new Stopwatch();
        ///<include file ='info.xml' path='doc/members/member[@name="SolutionChoise"]'/>
        public static void SolutionChoise(ConsoleKeyInfo key, string[] strings)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nYou have received this array:-------------------------------->");
            Console.SetCursorPosition(64, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{string.Join(", ", strings)}]");
            Console.SetCursorPosition(64, 3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Array length = {strings.Length}\n");
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        Solutions.SolutionOption(key, strings);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Solutions.SolutionOption(key, strings);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Solutions.SolutionOption(key, strings);
                        break;
                    }
                default:
                    {
                        Text.SelectOption();
                        key = Console.ReadKey();
                        Console.Beep();
                        SolutionChoise(key, strings);
                        break;
                    }
            }
        }
        ///<include file ='info.xml' path='doc/members/member[@name="SolutionOption"]'/>
        public static void SolutionOption(ConsoleKeyInfo key, string[] strings)
        {
            var temp = new string[0];
            if (key.Key == ConsoleKey.D1) temp = Methods.ArrayFormation1(strings);
            if (key.Key == ConsoleKey.D2) temp = Methods.ArrayFormation2(strings);
            if (key.Key == ConsoleKey.D3) temp = Methods.ArrayFormation3(strings);
            time.Start();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nAs a result of this solution, we got an array like this:----->  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{string.Join(", ", temp)}]");
            Console.SetCursorPosition(64, 8);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Array length = {temp.Length}");
            time.Stop();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nTime taken to complete this solution:\t" +
                $"{time.Elapsed}\n");
        }
    }
}