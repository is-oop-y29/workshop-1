using System.Diagnostics;
using Workshop1.Expressions.BinaryOperators;

namespace Workshop1.Expressions.Expressions;

public sealed class BinaryOperatorExpression(
    IExpression left,
    IExpression right,
    IBinaryOperator binaryOperator)
    : IExpression
{
    public ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context)
    {
        return (left.Evaluate(context), right.Evaluate(context)) switch
        {
            (ExpressionEvaluationResult.Full l, ExpressionEvaluationResult.Full r)
                => new ExpressionEvaluationResult.Full(binaryOperator.Calculate(l.Value, r.Value)),

            (ExpressionEvaluationResult.Full l, ExpressionEvaluationResult.Partial r)
                => new ExpressionEvaluationResult.Partial(new BinaryOperatorExpression(
                    new ConstantExpression(l.Value),
                    r.Expression,
                    binaryOperator)),

            (ExpressionEvaluationResult.Partial l, ExpressionEvaluationResult.Full r)
                => new ExpressionEvaluationResult.Partial(new BinaryOperatorExpression(
                    l.Expression,
                    new ConstantExpression(r.Value),
                    binaryOperator)),

            (ExpressionEvaluationResult.Partial l, ExpressionEvaluationResult.Partial r)
                => new ExpressionEvaluationResult.Partial(new BinaryOperatorExpression(
                    l.Expression,
                    r.Expression,
                    binaryOperator)),

            _ => throw new UnreachableException(),
        };
    }

    public string Format()
    {
        return $"({binaryOperator.Format(left.Format(), right.Format())})";
    }
}
