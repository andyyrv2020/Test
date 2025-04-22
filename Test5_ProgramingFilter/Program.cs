namespace Test5_ProgramingFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            List<int> oddNumbers = numbers.Where(n => n % 2 != 0)
                                          .OrderBy(n => n)
                                          .ToList();

            Console.WriteLine(string.Join(", ", oddNumbers));
        }
    }
}
