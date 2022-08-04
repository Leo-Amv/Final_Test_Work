namespace FinalTestWork
{
    class Solutions
    {
        public static void FirstOption()
        {
            string[] strings = Methods.UserInput().Split(' ');
            Console.WriteLine(string.Join(" ", Methods.ArrayFormation1(strings)));
        }
        public static void SecondOption()
        {
            string[] strings = Methods.UserInput().Split(' ');
            Console.WriteLine(string.Join(" ", Methods.ArrayFormation2(strings)));
        }
    }
}