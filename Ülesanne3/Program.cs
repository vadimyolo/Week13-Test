using System;
using System.IO;
using System.Collections.Generic;

namespace Ülesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stars = new List<string>();
            List<string> planets = new List<string>();

            string filePath = @"C:\Users\opilane\samples\Samples\MilkyWay.txt";
            string[] milkyway = File.ReadAllLines(filePath);

            string starPath = @"C:\Users\opilane\samples\Samples\stars.txt";


            string planetPath = @"C:\Users\opilane\samples\Samples\planets.txt";

            foreach (string element in milkyway)
            {
                if (element.Contains("star"))
                {
                    stars.Add(element);
                }
                if (element.Contains("planet"))
                {
                    planets.Add(element);
                }
            }


            File.WriteAllLines(starPath, stars);
            File.WriteAllLines(planetPath, planets);
        }
    }
}