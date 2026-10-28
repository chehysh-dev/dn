using System;

namespace caldelegate
{
    delegate double ArithmeticOperation(double a, double b);

    class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not possible.");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            ArithmeticOperation op;

            op = Add;
            Console.WriteLine("Addition = " + op(num1, num2));

            op = Subtract;
            Console.WriteLine("Subtraction = " + op(num1, num2));

            op = Multiply;
            Console.WriteLine("Multiplication = " + op(num1, num2));

            op = Divide;
            Console.WriteLine("Division = " + op(num1, num2));
        }
    }
}
