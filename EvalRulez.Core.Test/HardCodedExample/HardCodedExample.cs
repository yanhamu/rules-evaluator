using EvalRulez.Core.Expressions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace EvalRulez.Core.Test.HardCodedExample
{
    [TestFixture]
    public class HardCodedExample
    {
        public IEnumerable<Class> Classes
        {
            get
            {
                var maleAdultRules = new IExpression[] { new AdultPersonRule(), new MalePersonRule() };
                var youngFemaleRules = new IExpression[] { new YoungPersonRule(), new FemalePersonRule() };

                var class1 = new Class(maleAdultRules) { Name = "class Adult Male Person" };
                var class2 = new Class(youngFemaleRules) { Name = "class Young Female Person" };
                var class3 = new Class(new IExpression[] { new Not(maleAdultRules), new Not(youngFemaleRules) }) { Name = "Other" };

                return new Class[] { class1, class2, class3 };
            }
        }

        [Test]
        public void EvaluateMaleAdult()
        {
            var allClasses = Classes;
            var adultMaleClass = allClasses.Single(c => c.Name == "class Adult Male Person");

            var evaluator = new Evaluator(allClasses);

            var adultMale = new Person() { Age = 23, Name = "Tomas", Sex = Sex.male };
            var result = evaluator.Evaluate(adultMale);

            Assert.AreSame(adultMaleClass, result);
        }
    }
}
