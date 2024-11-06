using System;
using CalculatorApp.Model;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int input;
            bool active = true;
            Console.Clear();
            Console.WriteLine("Welcome to the Calculator App!");
            do
            {
                Calculator.Menu();

                input = int.TryParse(Console.ReadLine(), out input) ? input : 0;

                switch (input)
                {
                    case 1:
                        AddMenu(calculator);
                        break;
                    case 2:
                        SubtractMenu(calculator);
                        break;
                    case 3:
                        MultiplyMenu(calculator);
                        break;
                    case 4:
                        DivideMenu(calculator);
                        break;
                    case 5:
                        CustomExpressionMenu(calculator);
                        break;
                    case 6:
                        ExponentialMenu(calculator);
                        break;
                    case 7:
                        Console.WriteLine("Exiting");
                        active = false;
                        break;

                }
            } while (active);
        }
        static void AddMenu(Calculator calculator)
        {
            List<double> dynamicNumbers = [];
            Console.Write("How many Numbers : ");
            int total = int.TryParse(Console.ReadLine(), out total) ? total : 0;
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                var DynamicNumber = Console.ReadLine();
                dynamicNumbers.Add(double.TryParse(DynamicNumber, out double number) ? number : 0);
            }
            Console.Clear();
            Console.WriteLine($"Sum: {calculator.Add(dynamicNumbers)}");
            dynamicNumbers.Clear();
        }

        static void SubtractMenu(Calculator calculator)
        {
            List<double> dynamicNumbers = [];

            Console.Write("How many Numbers : ");
            int total = int.TryParse(Console.ReadLine(), out total) ? total : 0;
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                var DynamicNumber = Console.ReadLine();
                dynamicNumbers.Add(double.TryParse(DynamicNumber, out double number) ? number : 0);
            }
            Console.Clear();

            Console.WriteLine($"Result Of Subtraction: {calculator.Subtract(dynamicNumbers)}");
            dynamicNumbers.Clear();
        }

        static void MultiplyMenu(Calculator calculator)
        {
            List<double> dynamicNumbers = [];

            Console.Write("How many Numbers : ");
            int total = int.TryParse(Console.ReadLine(), out total) ? total : 0;
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                var DynamicNumber = Console.ReadLine();
                dynamicNumbers.Add(double.TryParse(DynamicNumber, out double number) ? number : 0);
            }
            Console.Clear();

            Console.WriteLine($"Result Of Multiplication: {calculator.Multiply(dynamicNumbers)}");
            dynamicNumbers.Clear();
        }

        static void DivideMenu(Calculator calculator)
        {
            List<double> dynamicNumbers = [];

            Console.Write("How many Numbers : ");
            int total = int.TryParse(Console.ReadLine(), out total) ? total : 0;
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                var DynamicNumber = Console.ReadLine();
                dynamicNumbers.Add(double.TryParse(DynamicNumber, out double number) ? number : 0);
            }
            Console.Clear();

            Console.WriteLine($"Result Of Division: {calculator.Divide(dynamicNumbers)}");
            dynamicNumbers.Clear();
        }

        static void ExponentialMenu(Calculator calculator) {
            Console.Write("Enter the base number: ");
            double baseNumber = double.TryParse(Console.ReadLine(), out baseNumber)? baseNumber : 0;
            Console.Write("Enter the exponent: ");
            double exponent = double.TryParse(Console.ReadLine(), out exponent)? exponent : 0;
            Console.WriteLine($"Result Of Exponential: {calculator.Exponential(baseNumber, exponent)}");
        }
        static void CustomExpressionMenu(Calculator calculator)
        {
            Console.Write("Enter your custom expression: ");
            string expression = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Result Of Custom Expression: {calculator.EvaluateExpression(expression)}");
        }
    }

}