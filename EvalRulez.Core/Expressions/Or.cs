using EvalRulez.Core.FluentRule;
using System.Collections.Generic;
using System.Linq;

namespace EvalRulez.Core.Expressions
{
    public class Or<T> : IExpression<T>
    {
        public IEnumerable<IExpression<T>> Expressions { get; set; }

        public Or(IEnumerable<IExpression<T>> expression)
        {
            this.Expressions = expression;
        }

        public Or(IExpression<T> a, IExpression<T> b)
        {
            var expressions = new List<IExpression<T>>() { a, b };
            this.Expressions = expressions;
        }

        public bool Evaluate(T objectToEvaluate)
        {
            return this.Expressions.Any(e => e.Evaluate(objectToEvaluate));
        }
    }
}
