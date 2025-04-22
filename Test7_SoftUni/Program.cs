namespace Test7_SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pages = new Stack<string>(); //от лист става на стек
            string current = null; //текуща страница

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }
                if (command == "back")
                {
                    if (pages.Count > 0)
                    {
                        current = pages.Pop();
                        Console.WriteLine(current);
                    }
                    else
                    {
                        Console.WriteLine("No previus pages");
                    }
                }
                else
                {
                    if (current != null)
                    {
                        pages.Push(current);
                    }
                    current = command;
                }
            }
        }
    }
}
