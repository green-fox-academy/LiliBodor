using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            Console.WriteLine(PutSaturn(planetList));

        }
        public static string PutSaturn(List<string> planetList)
        {
            planetList.Insert(5, "Saturn");

            return string.Join(", ", planetList);
        }

    }
}