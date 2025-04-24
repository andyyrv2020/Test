namespace Test11_Understring
{
    internal class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p'; //Latin P
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = i + jump; //i+jump

                    if (endIndex >= text.Length) // >=
                    {
                        endIndex = text.Length - 1; // -1
                    }

                    string matchedString = text.Substring(i, endIndex - i + 1); // i, endIndex - i + 1
                    Console.WriteLine(matchedString);
                    i = endIndex; // i = endIndex
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
