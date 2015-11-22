using System.Collections.Generic;
using System.Linq;

namespace EvalRulez.Core.Expressions
{
    public class Or : IExpression
    {
        public IEnumerable<IExpression> Expressions { get; set; }

        public Or(IEnumerable<IExpression> expression)
        {
            this.Expressions = expression;
        }

        public bool Evaluate(object evaluatedObject)
        {
            return Expressions.Any(e => e.Evaluate(evaluatedObject));
        }
    }
}
