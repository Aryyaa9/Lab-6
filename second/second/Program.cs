using System;
using System.IO;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask2.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadLine();

                while (str != null)
                {
                    Console.Write(str + " ");
                    str = reader.ReadLine();
                }
            }
        }
    }
}
