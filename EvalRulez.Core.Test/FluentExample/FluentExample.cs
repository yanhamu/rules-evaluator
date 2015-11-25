using EvalRulez.Core.FluentRule;
using NUnit.Framework;

namespace EvalRulez.Core.Test.FluentExample
{
    [TestFixture]
    public class FluentExample
    {
        [Test]
        public void Test()
        {
            var evaluator = new Evaluator<Person>(
                Rule<Person>.When(p => p.Age > 20).And(p => p.Name != "Tomas").ClassifyAs("OldTomas"),
                Rule<Person>.When(p => p.Age < 20).And(p => p.Name == "Ignac").ClassifyAs("IgnacClass")
                );

            var person = new Person() { Age = 10, Name = "Ignac" };

            var c = evaluator.Evaluate(person);

            Assert.AreEqual("IgnacClass", c.Name);
        }
    }
}
