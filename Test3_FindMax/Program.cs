namespace Test3_FindMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static double GetMaxValue(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }

            double max = numbers[0]; 
            foreach (double number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

    }
}
