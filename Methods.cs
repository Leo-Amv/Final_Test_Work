namespace FinalTestWork
{
    class Methods
    {
        public static string[] ArrayFormation1(string[] strings)
        {
            string temp = string.Empty;
            for (int i = 0; i < strings.Length; i++)
            {
                //if (strings[strings.Length - 1].Length > 3) Console.WriteLine();
                if (strings[i].Length <= 3 && strings[i] != " " && !string.IsNullOrEmpty(strings[i]))
                {
                    if (i == strings.Length - 1) temp += strings[i];
                    else temp += strings[i] + " ";
                }
            }
            return temp.Split(' '); ;
        }
        public static string[] ArrayFormation2(string[] strings)
        {
            string[] temp = new string[strings.Length];
            int size = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length <= 3 && strings[i] != " " && !string.IsNullOrEmpty(strings[i]))
                {
                    temp[size] = strings[i];
                    size++;
                }
            }
            Array.Resize(ref temp, size);
            return temp;
        }
        public static string UserInput()
        {
            Console.WriteLine("Введите несколько значений через пробел");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                return UserInput();
            }
        }
    }
}