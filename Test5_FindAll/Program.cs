namespace Test5_FindAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            list.FindAll(x => (x % 2) == 0).ForEach(x => Console.WriteLine(x));
        }
    }
}
