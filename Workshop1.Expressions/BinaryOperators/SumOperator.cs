namespace Workshop1.Expressions.BinaryOperators;

public sealed class SumOperator : IBinaryOperator
{
    public double Calculate(double left, double right) => left + right;

    public string Format(string left, string right) => $"{left} + {right}";
}
