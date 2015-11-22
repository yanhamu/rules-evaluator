using EvalRulez.Core.Expressions;

namespace EvalRulez.Core.Test.HardCodedExample
{
    public class FemalePersonRule : IExpression
    {
        public bool Evaluate(object evaluatedObject)
        {
            var person = evaluatedObject as Person;
            return person.Sex == Sex.female;
        }
    }
}