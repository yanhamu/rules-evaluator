using EvalRulez.Core.FluentRule;
using System;

namespace EvalRulez.Core.Expressions
{
    public class SimpleExpression<T> : IExpression<T>
    {
        private readonly Func<T, bool> expression;

        public SimpleExpression(Func<T, bool> expression)
        {
            this.expression = expression;
        }

        public bool Evaluate(T objectToEvaluate)
        {
            return expression(objectToEvaluate);
        }
    }
}
