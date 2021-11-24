using System;
using System.IO;


namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\opilane\samples";
            Console.WriteLine("Palun sisestage teie kausta nime");
            string userFilename = Console.ReadLine();
            string newDirectory = $@"{path}\{userFilename}";

            bool directoryExists = Directory.Exists(newDirectory);

            if (directoryExists)
            {
                Console.WriteLine($"{userFilename} juba eksisteerib.");
            }
            else
            {
                Directory.CreateDirectory(newDirectory);
                Console.WriteLine($"Kaust nimega {userFilename} on loodud.");
            }
            Console.ReadLine();
        }
    }
}
