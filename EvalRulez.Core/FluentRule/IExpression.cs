namespace EvalRulez.Core.FluentRule
{
    public interface IExpression<T>
    {
        bool Evaluate(T objectToEvaluate);
    }
}