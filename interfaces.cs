public interface ICalculator {
    double Add(List<double> numbers);
    double Subtract(List<double> numbers);
    double Multiply(List<double> numbers);
    double Divide(List<double> numbers);
    double Exponential(double baseNumber, double exponent);
    public double EvaluateExpression(string expression);
    

   /*  T Subtract<T>(List<T> numbers);
    T Multiply<T>(List<T> numbers);
    T Divide<T>(List<T> numbers);
    T Exponential <T>(List<T> numbers); */
}