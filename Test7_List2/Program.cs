namespace Test7_List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < collection.Count; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Count; curr++)
                {
                    if (collection[curr] < collection[min]) // <
                    {
                        min = curr;
                    }
                }
                int temp = collection[index]; // store the current value
                collection[index] = collection[min];
                collection[min] = temp; // swap
            }
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
