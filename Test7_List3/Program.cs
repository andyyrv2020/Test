namespace Test7_List3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count - 1; i++)//< list.Count - 1
            {
                for (int j = 0; j < list.Count - i -1; j++) // - i - 1
                {
                    if (list[j] > list[j + 1])//j > j + 1
                    {
                        int temp = list[j]; //store the current value
                        list[j] = list[j + 1]; //swap j = j + 1
                        list[j + 1] = temp; //j + 1 = temp 
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
