using System;
using System.Collections.Generic;
using System.Linq;

namespace Test16_WeatherCacl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 15, 13, 12, 12, 19, 22, 21, 18 };
            var avg = input.Average();
            Console.WriteLine($"Avg temp: {avg}");
        }
    }
}
