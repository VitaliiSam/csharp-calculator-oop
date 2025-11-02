// See https://aka.ms/new-console-template for more information
using CalculatorLib;

internal class Program
{
    private static double a;
    private static double b;

    private static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        //check if user enter first number, if not - asked to try again
        try
        {
            a = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not a number. Please enter again: ");
            a = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Enter second number: ");
        //check if user enter second number, if not - asked to try again
        try
        {
            b = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("This is not a number. Please enter again: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Select operation: + - * /");
        string operation = Console.ReadLine();
        if (operation == "+")
        {
            double add = Calculator.Add(a, b);
            Console.WriteLine($"Result of adding numbers: {add}");
        }
        else if (operation == "-")
        {
            double subtract = Calculator.Subtract(a, b);
            Console.WriteLine($"Result of subtracting numbers: {subtract}");
        }
        else if (operation == "*")
        {
            double multiply = Calculator.Multiply(a, b);
            Console.WriteLine($"Result of multiplying numbers: {multiply}");
        }
        else if (operation == "/")
        {
            try
            {
                double divide = Calculator.Divide(a, b);
                Console.WriteLine($"Result of dividing numbers: {divide}");
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
            }
        }
        else
        {
            Console.WriteLine("Unknown operation");
        }

        Console.WriteLine($"Last result: {Calculator.LastResult}");
    }
}