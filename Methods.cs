namespace FinalTestWork
{
    class Methods
    {
        ///<include file ='info.xml' path='doc/members/member[@name="ArrayFormation1"]'/>
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
        ///<include file ='info.xml' path='doc/members/member[@name="ArrayFormation2"]'/>
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
        ///<include file ='info.xml' path='doc/members/member[@name="ArrayFormation3"]'/>
        public static string[] ArrayFormation3(string[] strings)
        {
            return Array.FindAll(strings, x => x.Length <= 3 && x != " " && !string.IsNullOrEmpty(x));
        }
        ///<include file ='info.xml' path='doc/members/member[@name="UserInput"]'/>
        public static string[] UserInput()
        {
            Console.Clear();
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
        ///<include file ='info.xml' path='doc/members/member[@name="ReadyArray"]'/>
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
    }
}