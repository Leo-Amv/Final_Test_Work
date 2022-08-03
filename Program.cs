using System;
namespace FinalTestWork
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите несколько значений через пробел");
            string? userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                string[] strings = userInput.Split(' ');
                string temp = string.Empty;
                for (int i = 0; i < strings.Length; i++)
                {
                    if (strings[i].Length <= 3 && strings[i] != " " && !string.IsNullOrEmpty(strings[i]))
                    {
                        if (i == strings.Length - 1) temp += strings[i];
                        else temp += strings[i] + " ";
                    }
                }
                string[] result = temp.Split(' ');
                Console.WriteLine(string.Join(" ", result));
                //Console.WriteLine($"\n{strings.Length}\t{result.Length}\t _{strings[2]}_\t_{result[2]}_");
                // Console.WriteLine(string.Join("_", strings));
                // Console.WriteLine(strings.Length);
            }
            else
            {
                Main();
            }
        }
    }
}