using System.Collections.Generic;

namespace EvalRulez.Core
{
    public class Evaluator
    {
        private readonly IEnumerable<Class> classes;

        public Evaluator(IEnumerable<Class> classes)
        {
            this.classes = classes;
        }

        public Class Evaluate(object evaluatedObject)
        {
            foreach (var c in classes)
            {
                if (c.Evaluate(evaluatedObject))
                    return c;
            }

            throw new ClassNotFoundException();
        }
    }
}
