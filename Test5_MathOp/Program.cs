namespace Test5_MathOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()

                            .Split()

                            .Select(int.Parse)

                            .ToList();



            string cmd = Console.ReadLine();



            while (!cmd.Equals("end"))

            {

                switch (cmd)

                {

                    case "add":

                        numbers = numbers.Select(addition).ToList();

                        break;

                    case "multiply":

                        numbers = numbers.Select(multiplication).ToList();

                        break;

                    case "subtract":

                        numbers = numbers.Select(subtraction).ToList();

                        break;

                    case "print":

                        foreach (var item in numbers)

                        {

                            print(item);

                        }

                        Console.WriteLine();

                        break;

                }



                cmd = Console.ReadLine();

            }
        }

        static int addition(int number)
        {
            return number + 1;
        }
        static int multiplication(int number)
        {
            return number * 2;
        }
        static int subtraction(int number)
        {
            return number - 1;
        }
        static void print(int number)
        {
            Console.Write(number + " ");
        }
    }
}
