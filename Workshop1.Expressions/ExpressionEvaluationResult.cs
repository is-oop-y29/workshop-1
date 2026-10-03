using System.Diagnostics;
using System.Globalization;

namespace Workshop1.Expressions;

public abstract record ExpressionEvaluationResult
{
    private ExpressionEvaluationResult() { }

    public sealed record Full(double Value) : ExpressionEvaluationResult
    {
        public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    }

    public sealed record Partial(IExpression Expression) : ExpressionEvaluationResult
    {
        public override string ToString() => Expression.Format();
    }
}
