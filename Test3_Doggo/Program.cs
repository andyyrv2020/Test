namespace Test3_Doggo
{
    public class Dog
    {
        private static int count; // Changed to static to ensure it tracks across all instances
        public Dog()
        {
            count++;
        }

        public int Count { get => count; }
    }
        
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Console.WriteLine(dog1.Count); // Will now correctly show the count of all Dog instances
        }
    }


}
