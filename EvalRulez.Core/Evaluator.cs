using System.Collections.Generic;

namespace EvalRulez.Core
{
    public class Evaluator<T>
    {
        private readonly IEnumerable<Class<T>> classes;

        public Evaluator(params Class<T>[] classes)
        {
            this.classes = classes;
        }

        public Class<T> Evaluate(T evaluatedObject)
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
