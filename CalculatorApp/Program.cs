// See https://aka.ms/new-console-template for more information
using CalculatorLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter first value: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second value: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double add = Calculator.Add(a, b);
        Console.WriteLine($"Result of adding numbers: {add}");

        double subtract = Calculator.Subtract(a, b);
        Console.WriteLine($"Result of subtracting numbers: {subtract}");

        double multiply = Calculator.Multiply(a, b);
        Console.WriteLine($"Result of multiplying numbers: {multiply}");

        double divide = Calculator.Divide(a, b);
        Console.WriteLine($"Result of dividing numbers: {divide}");

        Console.WriteLine($"Last result: {Calculator.LastResult}");
    }
}