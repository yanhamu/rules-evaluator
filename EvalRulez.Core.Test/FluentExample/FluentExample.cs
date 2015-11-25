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
            var c1 = Rule<Person>.When(p => p.Age > 20)
                .And(p => p.Name != "Tomas")
                .ClassifyAs("OldTomas");
            var c2 = Rule<Person>.When(p => p.Age < 20).And(p => p.Name == "Ignac").ClassifyAs("young Ignac");
            var person = new Person() { Age = 10, Name = "Ignac" };

            Assert.IsFalse(c1.Evaluate(person));
            Assert.IsTrue(c2.Evaluate(person));
        }
    }
}
