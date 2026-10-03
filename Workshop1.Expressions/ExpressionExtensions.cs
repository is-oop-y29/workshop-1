using Workshop1.Expressions.BinaryOperators;
using Workshop1.Expressions.Expressions;

namespace Workshop1.Expressions;

public static class ExpressionExtensions
{
    extension(IExpression)
    {
        public static IExpression operator +(IExpression left, IExpression right)
        {
            return new BinaryOperatorExpression(
                left,
                right,
                new SumOperator());
        }
        
        public static IExpression operator *(IExpression left, IExpression right)
        {
            return new BinaryOperatorExpression(
                left,
                right,
                new MultiplyOperator());
        }

        public static IExpression operator -(IExpression expression)
            => new NegateExpressionDecorator(expression);
    }

    public static IExpression Variable(string value) => new VariableExpression(value);

    public static IExpression Constant(double value) => new ConstantExpression(value);
}
