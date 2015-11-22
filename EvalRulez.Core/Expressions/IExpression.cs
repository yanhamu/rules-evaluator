namespace EvalRulez.Core.Expressions
{
    public interface IExpression
    {
        bool Evaluate(object evaluatedObject);
    }
}