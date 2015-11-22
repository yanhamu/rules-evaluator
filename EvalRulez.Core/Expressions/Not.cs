namespace EvalRulez.Core.Expressions
{
    public class Not : IExpression
    {
        private readonly IExpression expression;

        public Not(IExpression expression)
        {
            this.expression = expression;
        }

        public Not(IExpression[] expressions)
        {
            this.expression = new And(expressions);
        }

        public bool Evaluate(object evaluatedObject)
        {
            return !expression.Evaluate(evaluatedObject);
        }
    }
}
