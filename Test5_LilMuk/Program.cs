using System.Linq;

namespace Test5_LilMuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            names.Where(name => name.Length <= length) //name => name.Length <= length
                 .ToList()
                 .ForEach(name => Console.WriteLine(name));//name => Console.WriteLine(name)
        }

    }
}
