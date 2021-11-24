using System;
using System.IO;


namespace Ülesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\Samples";
            string userFilename = Console.ReadLine();
            string newDirectory = $@"{ rootDirectory}\{userFilename}";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExist = File.Exists(newDirectory);

            if (directoryExists && fileExist)
            {
                Console.WriteLine($"{userFilename} on juba olemas {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} ei eksisteeri.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} on loodud.");
                File.Create(newDirectory);
                Console.WriteLine($"{userFilename}.txt on loodud {rootDirectory}.");
            }
            else
            {
                File.Create(newDirectory);
                Console.WriteLine($"{userFilename} on loodud {newDirectory}");
            }
        }
    }
}
