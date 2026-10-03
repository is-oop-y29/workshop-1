namespace Workshop1.Expressions.Expressions;

public sealed class VariableExpression(string variableName) : IExpression
{
    public ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context)
    {
        return context.TryGetValue(variableName, out double value)
            ? new ExpressionEvaluationResult.Full(value)
            : new ExpressionEvaluationResult.Partial(this);
    }

    public string Format() => variableName;
}
