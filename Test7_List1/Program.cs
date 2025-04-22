namespace Test7_List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int j = 0; j <= list.Count - 2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i]; // new variable
                        list[i] = list[i + 1];
                        list[i + 1] = temp; // swap
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
