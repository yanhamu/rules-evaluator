using EvalRulez.Core.FluentRule;

namespace EvalRulez.Core.Expressions
{
    public class Not<T> : IExpression<T>
    {
        private readonly IExpression<T> expression;

        public Not(IExpression<T> expression)
        {
            this.expression = expression;
        }

        public Not(IExpression<T>[] expressions)
        {
            this.expression = new And<T>(expressions);
        }

        public bool Evaluate(T evaluatedObject)
        {
            return !expression.Evaluate(evaluatedObject);
        }
    }
}
