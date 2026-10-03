using System.Globalization;

namespace Workshop1.Expressions.Expressions;

public sealed class ConstantExpression(double value) : IExpression
{
    public ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context)
    {
        return new ExpressionEvaluationResult.Full(value);
    }

    public string Format() => value.ToString(CultureInfo.InvariantCulture);
}
