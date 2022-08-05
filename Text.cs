namespace FinalTestWork
{
    class Text
    {
        public static void Menu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
            Console.WriteLine("\nSELECT A MENU ITEM AND PRESS THE CORRESPONDING KEY:\n");
            Console.WriteLine("If you want to choose   ready array examples press the key:          \t1");
            Console.WriteLine("If you want if you want to enter array values yourself press the key:\t2");
        }
        public static void ArrayExamples()
        {
            Console.Clear();
            Console.WriteLine("Select ready array example and press the corresponding key:" +
                "\n\t(otherwise the first array will be used)");
            Console.WriteLine("\n[\"hello\", \"2\", \"world\", \":-)\"]\t\t\tkey:1");
            Console.WriteLine("\n[\"1234\", \"1567\", \"-2\", \"computer science\"]\tkey:2");
            Console.WriteLine("\n[\"Russia\", \"Denmark\", \"Kazan\"]\t\t\tkey:3\n");
        }
        public static void SelectOption()
        {
            Console.Clear();
            Console.WriteLine(
                "\nSelect solution and press the key:" +
                "\n\n\tFirst option:  \t key1" +
                "\n\n\tSecond option: \t key2" +
                "\n\n\tThird option:  \t key3");
        }
    }
}