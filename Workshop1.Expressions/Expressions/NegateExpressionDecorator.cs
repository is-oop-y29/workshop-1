using System.Diagnostics;

namespace Workshop1.Expressions.Expressions;

public sealed class NegateExpressionDecorator(
    IExpression expression)
    : IExpression
{
    public ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context)
    {
        return expression.Evaluate(context) switch
        {
            ExpressionEvaluationResult.Full full
                => new ExpressionEvaluationResult.Full(-full.Value),

            ExpressionEvaluationResult.Partial partial
                => new ExpressionEvaluationResult.Partial(new NegateExpressionDecorator(partial.Expression)),

            _ => throw new UnreachableException(),
        };
    }

    public string Format() => $"-{expression.Format()}";
}
