using System;

class Program
{
    static void Main()
    {

        string hexInput = Console.ReadLine();
        int decimalValue = Convert.ToInt32(hexInput, 16);
        Console.WriteLine($"Decimal: {decimalValue}");

    }
}
