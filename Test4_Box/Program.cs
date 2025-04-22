namespace Test4_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Box<T>
    {
        private List<T> items;
        public Box()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }
    }
}
