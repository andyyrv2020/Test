using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Test16_Matrix2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix = DenseMatrix.OfArray(new double[,] {
                                            { 1, 2, 5 },
                                            { 1, - 1, 2 },
                                            { 3, -6, -1 }
            });

            Vector<double> solve = new DenseVector(new[] { -9.0, 3.0, 25.0 }); //{
            var answer = matrix.Solve(solve);
            Console.WriteLine(string.Join(" ", answer.Select(x => Math.Round(x, 2))));
        }
    }
}
