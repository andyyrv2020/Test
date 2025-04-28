using System;
using MathNet.Numerics.Distributions;

class Program
{
    static void Main()
    {
        int throws = 5000;
        int[] counts = new int[6]; 

        var dice = new DiscreteUniform(1, 6); 

        for (int i = 0; i < throws; i++)
        {
            int result = dice.Sample(); 
            counts[result - 1]++;
        }

        for (int i = 0; i < 6; i++)
        {
            double probability = (double)counts[i] / throws;
            Console.WriteLine($"Num: {i + 1}: {probability:F4}");
        }
    }
}
