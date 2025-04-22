namespace Test2_Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0].Equals("END"))
            {
                if (!dict.ContainsKey(input))
                {
                    dict.Add(input[0], 1);
                }
                dict[input[0]] = int.Parse(input[1]);
                input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

