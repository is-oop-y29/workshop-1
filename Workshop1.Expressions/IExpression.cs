namespace Workshop1.Expressions;

public interface IExpression
{
    ExpressionEvaluationResult Evaluate(ExpressionEvaluationContext context);

    string Format();
}
