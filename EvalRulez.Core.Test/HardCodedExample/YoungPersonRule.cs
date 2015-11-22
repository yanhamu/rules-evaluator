using EvalRulez.Core.Expressions;

namespace EvalRulez.Core.Test.HardCodedExample
{
    public class YoungPersonRule : IExpression
    {
        public bool Evaluate(object evaluatedObject)
        {
            var person = evaluatedObject as Person;
            return person.Age < 15;
        }
    }
}