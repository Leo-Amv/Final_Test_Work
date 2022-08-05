using System.Diagnostics;
namespace FinalTestWork
{
    class Solutions
    {
        private static Stopwatch time = new Stopwatch();
        public static void FirstOption(string[] strings)
        {
            time.Start();
            Console.WriteLine("\nAs a result of this solution, we got an array like this:\t" +
                $"[{string.Join(",", Methods.ArrayFormation1(strings))}]");
            time.Stop();
            Console.WriteLine("\nTime taken to complete this solution:\t" +
                $"{time.Elapsed}\n");
        }
        public static void SecondOption(string[] strings)
        {
            time.Start();
            Console.WriteLine("\nAs a result of this solution, we got an array like this:\t" +
                $"[{string.Join(",", Methods.ArrayFormation2(strings))}]");
            time.Stop();
            Console.WriteLine("\nTime taken to complete this solution:\t" +
                $"{time.Elapsed}\n");
        }
    }
}