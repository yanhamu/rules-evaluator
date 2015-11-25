using EvalRulez.Core.FluentRule;
using System.Collections.Generic;
using System.Linq;

namespace EvalRulez.Core.Expressions
{
    public class And<T> : IExpression<T>
    {
        IEnumerable<IExpression<T>> expressions;

        public And(IEnumerable<IExpression<T>> expression)
        {
            this.expressions = expression;
        }

        public And(IExpression<T> a, IExpression<T> b)
        {
            var expression = new List<IExpression<T>>();
            expression.Add(a);
            expression.Add(b);
            this.expressions = expression;
        }

        public bool Evaluate(T evaluatedObject)
        {
            return expressions.All(e => e.Evaluate(evaluatedObject));
        }
    }
}
