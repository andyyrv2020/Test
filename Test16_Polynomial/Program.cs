using MathNet.Numerics;

namespace Test16_Polynomial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coef = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Reverse()
                .ToArray();

            var roots = FindRoots.Polynomial(coef);
            Console.WriteLine("Roots: " + string.Join(" ", roots));
        }
    }
}
