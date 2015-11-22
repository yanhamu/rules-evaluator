using EvalRulez.Core.Expressions;
using System.Collections.Generic;

namespace EvalRulez.Core
{
    public class Class
    {
        public string Name { get; set; }
        public IExpression Expression { get; set; }

        public Class(IExpression expression)
        {
            this.Expression = expression;
        }

        public Class(IEnumerable<IExpression> expressions)
        {
            this.Expression = new And(expressions);
        }

        internal bool Evaluate(object evaluatedObject)
        {
            return Expression.Evaluate(evaluatedObject);
        }
    }
}