using System.Runtime.InteropServices;

namespace Test1_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); //int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double dailyFoodFirst = double.Parse(Console.ReadLine());
            double dailyFoodSecond = double.Parse(Console.ReadLine()); //Console.ReadLine()
            double dailyFoodThird = double.Parse(Console.ReadLine());

            double foodNeeded = days * dailyFoodFirst + days * dailyFoodSecond + days * dailyFoodThird; //double


            if (kgFood >= foodNeeded) // >=
            {
                Console.WriteLine($"{Math.Floor(kgFood - foodNeeded)} kilos of food left."); //$
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - kgFood)} more kilos of food are needed."); //$
            }
        }
    }
}
