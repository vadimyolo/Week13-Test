using System;
using System.IO;

namespace Ülesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = $@"C:\Users\opilane\samples\Samples";
            Console.WriteLine("Mis file sisu tahate näha?");
            string userFile = Console.ReadLine();
            string fileDirectory = $@"{rootdirectory}\{userFile}.txt";
            bool exists = File.Exists(fileDirectory);
            if (exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirectory);
                if (userFile == "planets" || userFile == "stars")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt file ei eksisteeri.");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt ei eksisteeri.");
            }
        }
    }
}
