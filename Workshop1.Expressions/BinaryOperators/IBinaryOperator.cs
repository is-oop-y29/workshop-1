namespace Workshop1.Expressions.BinaryOperators;

public interface IBinaryOperator
{
    double Calculate(double left, double right);

    string Format(string left, string right);
}
