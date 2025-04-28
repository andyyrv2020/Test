namespace Test16_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3x3 matrix");
            double[,] matrix = new double[3, 3];

            for (int i = 0; i < 3; i++)
            {
                var j = 0;
                var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                foreach (var n in numbers)
                {
                    matrix[i, j] = n;
                    j++;
                }
            }

            Console.WriteLine("Please enter a number");
            double num = double.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] *= num);
                }

                Console.WriteLine();
            }

        }
    }
}
