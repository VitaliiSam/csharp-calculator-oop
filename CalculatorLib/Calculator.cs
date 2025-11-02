namespace CalculatorLib
{
    public class Calculator
    {
        public static double LastResult {  get; private set; }
        public static double Add (double a, double b)
        {
            LastResult = a + b;
            return LastResult;
        }
        public static double Subtract (double a, double b)
        {
            LastResult = a - b;
            return LastResult;
        }
        public static double Multiply (double a, double b)
        {
            LastResult = a * b;
            return LastResult;
        }
        public static double Divide (double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Can't divide by zero");
            }
            LastResult = a / b;
            return LastResult; 
        }
    }
}
