// See https://aka.ms/new-console-template for more information

using Workshop1.Expressions;
using Workshop1.Expressions.BinaryOperators;
using static Workshop1.Expressions.ExpressionExtensions;

IExpression expression = -(Variable("x") + Constant(1)) * Variable("y");

var context = new ExpressionEvaluationContext();
context.Add("x", 3);

Console.WriteLine(expression.Evaluate(context));

IBinaryOperator op = new DumbMultiplyOperator();
op = new BinaryOperatorCachingProxy(op);

Console.WriteLine(DateTimeOffset.UtcNow.ToUnixTimeSeconds());

Console.WriteLine(op.Calculate(1, 100));
Console.WriteLine(DateTimeOffset.UtcNow.ToUnixTimeSeconds());

Console.WriteLine(op.Calculate(1, 100));
Console.WriteLine(DateTimeOffset.UtcNow.ToUnixTimeSeconds());
