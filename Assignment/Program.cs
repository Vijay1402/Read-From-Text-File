using System;
using System.IO;

namespace Assignment
{
    internal class Program
    {
        static readonly string textFile = @"StudentDetails.txt";
        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
                Console.WriteLine("Here are the Student Details");
                using (StreamReader file = new StreamReader(textFile))
                {
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                    }
                    file.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
