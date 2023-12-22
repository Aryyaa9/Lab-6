using System;
namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 10 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}