namespace FinalTestWork
{
    class Methods
    {
        public static string[] ArrayFormation1(string[] strings)
        {
            string temp = string.Empty;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length <= 3 && strings[i] != " " && !string.IsNullOrEmpty(strings[i]))
                {
                    if (string.IsNullOrEmpty(temp)) temp += "'" + strings[i] + "'";
                    else temp += " " + "'" + strings[i] + "'";
                }
            }
            if (temp == string.Empty) return new string[0];
            else return temp.Split(' ');
        }
        public static string[] ArrayFormation2(string[] strings)
        {
            string[] temp = new string[strings.Length];
            int size = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length <= 3 && strings[i] != " " && !string.IsNullOrEmpty(strings[i]))
                {
                    temp[size] = "'" + strings[i] + "'";
                    size++;
                }
            }
            if (size == 0) return new string[0];
            else
            {
                Array.Resize(ref temp, size);
                return temp;
            }
        }
        public static string[] ArrayFormation3(string[] strings)
        {
            return Array.FindAll(strings, x => x.Length <= 3 && x != " " && !string.IsNullOrEmpty(x));
        }
        public static string[] UserInput()
        {
            Console.WriteLine("\nEnter array values separated by spaces");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input.Split(' ');
            }
            else
            {
                return UserInput();
            }
        }
        public static string[] ReadyArray(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        string[] strings = { "hello", "2", "world", ":-)" };
                        return strings;
                    }
                case ConsoleKey.D2:
                    {
                        string[] strings = { "1234", "1567", "-2", "computer science" };
                        return strings;
                    }
                case ConsoleKey.D3:
                    {
                        string[] strings = { "Russia", "Denmark", "Kazan" };

                        return strings;
                    }

                default:
                    {
                        goto case ConsoleKey.D1;
                    }
            }
        }
        public static void DecisionChoise(ConsoleKeyInfo key, string[] strings)
        {
            Console.Clear();
            Console.Write($"\nYou have received this array:-------------------------------->");
            Console.SetCursorPosition(64, 1);
            Console.Write($"[{string.Join(", ", strings)}]");
            Console.SetCursorPosition(64, 3);
            Console.WriteLine($"Array length = {strings.Length}\n");
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        Solutions.FirstOption(strings);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Solutions.SecondOption(strings);
                        break;
                    }
                default:
                    {
                        Text.SelectOption();
                        key = Console.ReadKey();
                        Console.Beep();
                        DecisionChoise(key, strings);
                        break;
                    }
            }
        }
    }
}