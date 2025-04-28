using System;
using System.Collections.Generic;
using System.Numerics;

namespace Test17_VectorLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> lengths = new List<double>(); //List of double (lengths)
            for (int i = 0; i < 3; i++) //3
            {
                string input = Console.ReadLine(); //Readline, string
                string[] parts = input.Split(' '); //Overall string
                Vector3 v = new Vector3(
                    float.Parse(parts[0]), //X
                    float.Parse(parts[1]), //Y
                    float.Parse(parts[2])  //Z
                    );
                double length = v.Length(); //Length
                lengths.Add(length);
            }
            double shortestLength = Math.Min(lengths[0], Math.Min(lengths[1], lengths[2]));

            Console.WriteLine(shortestLength);
        }
    }
}
