namespace Test6_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 12, 8, 10, 2, 9, 6, 1 };
            BubbleSort(list);
            Console.WriteLine("List: " + string.Join(" ", list));
        }

        static void BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
