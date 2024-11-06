using System.Data;
using System.Text.RegularExpressions;

namespace CalculatorApp.Model
{
    public class Calculator : ICalculator
    {
        public double Add(List<double> numbers)
        {
            if (numbers.Count == 1)
            {
                return 0;
            }
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Subtract(List<double> numbers)
        {
            if (numbers.Count == 1)
            {
                return 0;
            }
            double result = 0;
            foreach (double number in numbers)
            {
                result -= number;
            }
            return result;
        }

        public double Multiply(List<double> numbers)
        {
            if (numbers.Count == 1)
            {
                return 0;
            }

            double result = 1.0;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public double Divide(List<double> numbers)
        {
            double result = 1.0;
            foreach (double number in numbers)
            {
                result /= number;
            }
            return result;
        }

        public double Exponential(double baseNumber, double exponent)
        {
            Console.Clear();
            return Math.Pow(baseNumber, exponent);
        }


        public double EvaluateExpression(string expression)
        {  
            expression = expression.Replace("(", "");
            expression = expression.Replace(")", "");
            // Handle "^" as exponentiation by replacing it with Math.Pow syntax
            expression = HandleExponentiation(expression);

            var table = new DataTable();
            var result = table.Compute(expression, "");
            return Convert.ToDouble(result);
        }

        private string HandleExponentiation(string expression)
        {
            // Regex to match the pattern "base ^ exponent" (e.g., "3 ^ 2")
            var exponentPattern = new Regex(@"(\d+(\.\d+)?)\s*\^\s*(\d+(\.\d+)?)");

            while (exponentPattern.IsMatch(expression))
            {
                var match = exponentPattern.Match(expression);

                // Extract base and exponent from match groups
                double baseNumber = Convert.ToDouble(match.Groups[1].Value);
                double exponent = Convert.ToDouble(match.Groups[3].Value);

                // Calculate the power
                double powerResult = Math.Pow(baseNumber, exponent);

                // Replace "base ^ exponent" with the computed result in the expression
                expression = expression.Replace(match.Value, powerResult.ToString());
            }

            return expression;
        }
        public static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add numbers");
            Console.WriteLine("2. Subtract numbers");
            Console.WriteLine("3. Multiply numbers");
            Console.WriteLine("4. Divide numbers");
            Console.WriteLine("5. Custom Expression");
            Console.WriteLine("6. Exponential");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
        }
    }
}