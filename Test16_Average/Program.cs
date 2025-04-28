namespace Test16_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] numbers = input.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();
            double average = numbers.Average();
            Console.WriteLine(average);
        }
    }
}
