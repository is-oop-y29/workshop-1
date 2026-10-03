namespace Workshop1.Expressions.BinaryOperators;

public sealed class BinaryOperatorCachingProxy(
    IBinaryOperator binaryOperator)
    : IBinaryOperator
{
    private readonly Dictionary<Key, double> _cache = [];

    public double Calculate(double left, double right)
    {
        var key = new Key(left, right);

        if (_cache.TryGetValue(key, out double value))
            return value;

        value = binaryOperator.Calculate(left, right);
        _cache[key] = value;

        return value;
    }

    public string Format(string left, string right)
    {
        return binaryOperator.Format(left, right);
    }

    private readonly record struct Key(double Left, double Right);
}
