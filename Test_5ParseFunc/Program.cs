namespace Test_5ParseFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            string[] tokens = input.Split(' ');
            int[] numbers = new int[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                numbers[i] = int.Parse(tokens[i]);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
