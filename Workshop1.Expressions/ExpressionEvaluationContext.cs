namespace Workshop1.Expressions;

public sealed class ExpressionEvaluationContext
{
    private readonly Dictionary<string, double> _values = [];

    public void Add(string variable, double value)
    {
        _values[variable] = value;
    }

    public bool TryGetValue(string variable, out double value)
    {
        return _values.TryGetValue(variable, out value);
    }
}
