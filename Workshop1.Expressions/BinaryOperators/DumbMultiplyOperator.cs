namespace Workshop1.Expressions.BinaryOperators;

public sealed class DumbMultiplyOperator : IBinaryOperator
{
    public double Calculate(double left, double right)
    {
        var result = 0d;

        for (var i = 0; i < (int)right; i++)
        {
            result += left;
            Thread.Sleep(100);
        }

        return result;
    }

    public string Format(string left, string right)
    {
        return $"{left} * {right}";
    }
}
