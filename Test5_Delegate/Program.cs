namespace Test5_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Sum);
            double result = myDelegate(3.5, 4.3);
            Console.WriteLine(result);
        }

        public delegate double MyDelegate(double x, double y);

        public static double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
