using EvalRulez.Core.FluentRule;

namespace EvalRulez.Core
{
    public class Class<T>
    {
        public string Name { get; set; }
        public IExpression<T> Expression { get; set; }

        public Class(IExpression<T> expression, string name)
        {
            this.Expression = expression;
            this.Name = name;
        }

        public bool Evaluate(T evaluatedObject)
        {
            return Expression.Evaluate(evaluatedObject);
        }
    }
}