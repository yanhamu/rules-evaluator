using System.Collections.Generic;
using System.Linq;

namespace EvalRulez.Core.Expressions
{
    public class And : IExpression
    {
        public IEnumerable<IExpression> Expressions { get; set; }

        public And(IEnumerable<IExpression> expression)
        {
            this.Expressions = expression;
        }

        public bool Evaluate(object evaluatedObject)
        {
            return Expressions.All(e => e.Evaluate(evaluatedObject));
        }
    }
}
