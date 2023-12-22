using System;
using System.IO;
namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask1.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadToEnd();
                string[] strs = str.Split(' ');

                foreach (string word in strs)
                {
                    if (word.Length % 2 != 0)
                        Console.WriteLine(word);
                }
            }

        }
    }
}